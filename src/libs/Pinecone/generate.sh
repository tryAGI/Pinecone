install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

install_autosdk_cli
rm -rf Generated

fetch_spec -o db_control.yaml https://raw.githubusercontent.com/pinecone-io/pinecone-api/main/2026-04/db_control_2026-04.oas.yaml
fetch_spec -o inference.yaml https://raw.githubusercontent.com/pinecone-io/pinecone-api/main/2026-04/inference_2026-04.oas.yaml

# Merge db_control + inference specs (same base URL: https://api.pinecone.io)
python3 -c "
import yaml

with open('db_control.yaml') as f:
    control = yaml.safe_load(f)

with open('inference.yaml') as f:
    inference = yaml.safe_load(f)

merged = control.copy()
merged['info']['title'] = 'Pinecone API'

# Merge paths
for path, ops in inference['paths'].items():
    merged['paths'][path] = ops

# Merge schemas
for name, schema in inference['components']['schemas'].items():
    if name not in merged['components']['schemas']:
        merged['components']['schemas'][name] = schema

# Merge tags
existing_tag_names = {t['name'] for t in merged.get('tags', [])}
for tag in inference.get('tags', []):
    if tag['name'] not in existing_tag_names:
        merged['tags'].append(tag)

# Remove existing securitySchemes (will be overridden by --security-scheme flag)
if 'securitySchemes' in merged.get('components', {}):
    del merged['components']['securitySchemes']
if 'security' in merged:
    del merged['security']

with open('openapi.yaml', 'w') as f:
    yaml.dump(merged, f, default_flow_style=False, sort_keys=False, allow_unicode=True)
"

rm -f db_control.yaml inference.yaml

# Auth: Api-Key header.
autosdk generate openapi.yaml \
  --namespace Pinecone \
  --clientClassName PineconeClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Header:Api-Key

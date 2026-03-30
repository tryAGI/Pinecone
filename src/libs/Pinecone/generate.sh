dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated

curl -o db_control.yaml https://raw.githubusercontent.com/pinecone-io/pinecone-api/main/2026-04/db_control_2026-04.oas.yaml
curl -o inference.yaml https://raw.githubusercontent.com/pinecone-io/pinecone-api/main/2026-04/inference_2026-04.oas.yaml

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

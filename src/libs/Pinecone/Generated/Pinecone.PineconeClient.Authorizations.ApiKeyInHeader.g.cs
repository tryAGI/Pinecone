
#nullable enable

namespace Pinecone
{
    public sealed partial class PineconeClient
    {

        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Header" &&
                    __authorization.Name == "Api-Key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Pinecone.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Api-Key",
                Value = apiKey,
            });
        }
    }
}
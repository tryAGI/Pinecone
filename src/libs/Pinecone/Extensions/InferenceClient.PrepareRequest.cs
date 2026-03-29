#nullable enable

namespace Pinecone;

public partial class InferenceClient
{
    partial void PrepareRequest(
        global::System.Net.Http.HttpClient client,
        global::System.Net.Http.HttpRequestMessage request)
    {
        if (request.Headers.Authorization is { Scheme: "Bearer", Parameter: { Length: > 0 } apiKey })
        {
            request.Headers.Authorization = null;
            request.Headers.TryAddWithoutValidation("Api-Key", apiKey);
        }
    }
}

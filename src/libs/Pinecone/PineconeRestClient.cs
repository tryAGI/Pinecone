using System.Net.Http.Json;
using Pinecone.Rest;

namespace Pinecone;

public sealed class PineconeRestClient : PineconeClient<RestTransport>
{
    public PineconeRestClient(string apiKey, string environment, HttpClient httpClient) : base(apiKey, environment, httpClient)
    {
    }

    public PineconeRestClient(string apiKey, Uri baseUrl, HttpClient httpClient) : base(apiKey, baseUrl, httpClient)
    {
    }
    
    public override async Task<Index<RestTransport>> GetIndex(IndexName name)
    {
        var response = await HttpClient.GetFromJsonAsync(
            $"/databases/{name.Value}",
            typeof(Index<RestTransport>),
            SerializerContext.Default) ?? throw new HttpRequestException("GetIndex request has failed.");

        var index = (Index<RestTransport>)response;
        var host = index.Status.Host;
        var apiKey = HttpClient.DefaultRequestHeaders.GetValues(Constants.RestApiKey).First();

        index.Transport = RestTransport.Create(host, apiKey);
        return index;
    }
}

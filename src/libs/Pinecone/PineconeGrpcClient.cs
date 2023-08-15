using System.Net.Http.Json;
using Pinecone.Grpc;
using Pinecone.Rest;

namespace Pinecone;

public sealed class PineconeGrpcClient : PineconeClient<GrpcTransport>
{
    public PineconeGrpcClient(string apiKey, string environment, HttpClient httpClient) : base(apiKey, environment, httpClient)
    {
    }

    public PineconeGrpcClient(string apiKey, Uri baseUrl, HttpClient httpClient) : base(apiKey, baseUrl, httpClient)
    {
    }
    
    public override async Task<Index<GrpcTransport>> GetIndex(IndexName name)
    {
        var response = await HttpClient.GetFromJsonAsync(
            $"/databases/{name.Value}",
            typeof(Index<GrpcTransport>),
            SerializerContext.Default) ?? throw new HttpRequestException("GetIndex request has failed.");

        var index = (Index<GrpcTransport>)response;
        var host = index.Status.Host;
        var apiKey = HttpClient.DefaultRequestHeaders.GetValues(Constants.RestApiKey).First();

        index.Transport = GrpcTransport.Create(host, apiKey);
        return index;
    }
}

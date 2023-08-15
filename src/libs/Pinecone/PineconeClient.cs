using System.Net.Http.Json;
using CommunityToolkit.Diagnostics;
using Pinecone.Grpc;
using Pinecone.Rest;

namespace Pinecone;

public class PineconeClient
{
    protected HttpClient HttpClient { get; set; }

    public PineconeClient(string apiKey, Uri baseUrl, HttpClient httpClient)
    {
        Guard.IsNotNullOrWhiteSpace(apiKey);
        Guard.IsNotNull(baseUrl);
        HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        HttpClient.BaseAddress = baseUrl;
        HttpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);
    }

    public PineconeClient(string apiKey, string environment, HttpClient httpClient)
        : this(apiKey, new Uri($"https://controller.{environment}.pinecone.io"), httpClient)
    {
    }

    public async Task<IndexName[]> ListIndexes()
    {
        var response = await HttpClient.GetFromJsonAsync("/databases", SerializerContext.Default.StringArray);
        if (response is null or { Length: 0 })
        {
            return Array.Empty<IndexName>();
        }

        var indexes = new IndexName[response.Length];
        foreach (var i in 0..response.Length)
        {
            indexes[i] = new(response[i]);
        }

        return indexes;
    }

    public Task CreateIndex(string name, uint dimension, Metric metric) =>
        CreateIndex(new IndexDetails { Name = name, Dimension = dimension, Metric = metric });

    public async Task CreateIndex(
        IndexDetails indexDetails,
        MetadataMap? metadataConfig = null,
        string? sourceCollection = null)
    {
        var request = CreateIndexRequest.From(indexDetails, metadataConfig, sourceCollection);
        var response = await HttpClient.PostAsJsonAsync(
            "/databases", request, SerializerContext.Default.CreateIndexRequest);

        await response.CheckStatusCode();
    }
    
    private async Task<(Index Index, string Host, string ApiKey)> GetIndexData(IndexName name)
    {
        var index = await HttpClient.GetFromJsonAsync(
            $"/databases/{name.Value}",
            SerializerContext.Default.Index) ?? throw new HttpRequestException("GetIndex request has failed.");

        var host = index.Status.Host;
        var apiKey = HttpClient.DefaultRequestHeaders.GetValues(Constants.RestApiKey).First();

        return (index, host, apiKey);
    }
    
    public async Task<IndexClient<RestTransport>> GetIndexWithRestTransport(IndexName name)
    {
        var (index, host, apiKey) = await GetIndexData(name);

        return new IndexClient<RestTransport>(index, RestTransport.Create(host, apiKey));
    }
    
    public async Task<IndexClient<GrpcTransport>> GetIndexWithGrpcTransport(IndexName name)
    {
        var (index, host, apiKey) = await GetIndexData(name);

        return new IndexClient<GrpcTransport>(index, GrpcTransport.Create(host, apiKey));
    }
    
    public async Task<IndexClient<GrpcTransport>> GetIndex(IndexName name)
    {
        return await GetIndexWithGrpcTransport(name);
    }
    
    public async Task ConfigureIndex(IndexName name, int replicas, string podType)
    {
        var request = new ConfigureIndexRequest { Replicas = replicas, PodType = podType };
        var response = await HttpClient.PatchAsJsonAsync(
            $"/databases/{name.Value}", request, SerializerContext.Default.ConfigureIndexRequest);

        await response.CheckStatusCode();
    }

    public async Task DeleteIndex(IndexName name) =>
        await (await HttpClient.DeleteAsync($"/databases/{name.Value}")).CheckStatusCode();

    public async Task<CollectionName[]> ListCollections()
    {
        var response = await HttpClient.GetFromJsonAsync("/collections", SerializerContext.Default.StringArray);
        if (response is null or { Length: 0 })
        {
            return Array.Empty<CollectionName>();
        }

        var collections = new CollectionName[response.Length];
        foreach (var i in 0..response.Length)
        {
            collections[i] = new(response[i]);
        }

        return collections;
    }

    public async Task CreateCollection(CollectionName name, IndexName source)
    {
        var request = new CreateCollectionRequest { Name = name, Source = source };
        var response = await HttpClient.PostAsJsonAsync(
            "/collections", request, SerializerContext.Default.CreateCollectionRequest);

        await response.CheckStatusCode();
    }

    public async Task<CollectionDetails> DescribeCollection(CollectionName name)
    {
        return await HttpClient.GetFromJsonAsync(
            $"/collections/{name.Value}",
            SerializerContext.Default.CollectionDetails)
                ?? ThrowHelpers.JsonException<CollectionDetails>();
    }

    public async Task DeleteCollection(CollectionName name) =>
        await (await HttpClient.DeleteAsync($"/collections/{name.Value}")).CheckStatusCode();
}

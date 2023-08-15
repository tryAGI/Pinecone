using System.Net.Http.Json;
using CommunityToolkit.Diagnostics;
using Pinecone.Grpc;
using Pinecone.Rest;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public class PineconeClient
{
    /// <summary>
    /// 
    /// </summary>
    protected HttpClient HttpClient { get; set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="baseUrl"></param>
    /// <param name="httpClient"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public PineconeClient(string apiKey, Uri baseUrl, HttpClient httpClient)
    {
        Guard.IsNotNullOrWhiteSpace(apiKey);
        Guard.IsNotNull(baseUrl);
        HttpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

        HttpClient.BaseAddress = baseUrl;
        HttpClient.DefaultRequestHeaders.Add("Api-Key", apiKey);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="apiKey"></param>
    /// <param name="environment"></param>
    /// <param name="httpClient"></param>
    public PineconeClient(string apiKey, string environment, HttpClient httpClient)
        : this(apiKey, new Uri($"https://controller.{environment}.pinecone.io"), httpClient)
    {
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<IndexName[]> ListIndexes()
    {
        var response = await HttpClient.GetFromJsonAsync("/databases", SerializerContext.Default.StringArray).ConfigureAwait(false);
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="dimension"></param>
    /// <param name="metric"></param>
    /// <returns></returns>
    public Task CreateIndex(string name, uint dimension, Metric metric)
    {
        return CreateIndex(new IndexDetails
        {
            Name = name,
            Dimension = dimension,
            Metric = metric,
        });
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="indexDetails"></param>
    /// <param name="metadataConfig"></param>
    /// <param name="sourceCollection"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public async Task CreateIndex(
        IndexDetails indexDetails,
        MetadataMap? metadataConfig = null,
        string? sourceCollection = null)
    {
        indexDetails = indexDetails ?? throw new ArgumentNullException(nameof(indexDetails));

        var request = CreateIndexRequest.From(indexDetails, metadataConfig, sourceCollection);
        var response = await HttpClient.PostAsJsonAsync(
            "/databases", request, SerializerContext.Default.CreateIndexRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);
    }
    
    private async Task<(Index Index, string Host, string ApiKey)> GetIndexData(IndexName name)
    {
        var index = await HttpClient.GetFromJsonAsync(
            $"/databases/{name.Value}",
            SerializerContext.Default.Index).ConfigureAwait(false) ?? throw new HttpRequestException("GetIndex request has failed.");

        var host = index.Status.Host;
        var apiKey = HttpClient.DefaultRequestHeaders.GetValues(Constants.RestApiKey).First();

        return (index, host, apiKey);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<IndexClient<RestTransport>> GetIndexWithRestTransport(IndexName name)
    {
        var (index, host, apiKey) = await GetIndexData(name).ConfigureAwait(false);

        return new IndexClient<RestTransport>(index, new RestTransport(host, apiKey));
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<IndexClient<GrpcTransport>> GetIndexWithGrpcTransport(IndexName name)
    {
        var (index, host, apiKey) = await GetIndexData(name).ConfigureAwait(false);

        return new IndexClient<GrpcTransport>(index, new GrpcTransport(host, apiKey));
    }
    
    /// <summary>
    /// Returns gRPC IndexClient.
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<IndexClient<GrpcTransport>> GetIndex(IndexName name)
    {
        return await GetIndexWithGrpcTransport(name).ConfigureAwait(false);
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="replicas"></param>
    /// <param name="podType"></param>
    public async Task ConfigureIndex(IndexName name, int replicas, string podType)
    {
        var request = new ConfigureIndexRequest { Replicas = replicas, PodType = podType };
        var response = await HttpClient.PatchAsJsonAsync(
            $"/databases/{name.Value}", request, SerializerContext.Default.ConfigureIndexRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public async Task DeleteIndex(IndexName name) =>
        await (await HttpClient.DeleteAsync(new Uri($"/databases/{name.Value}")).ConfigureAwait(false)).CheckStatusCode().ConfigureAwait(false);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public async Task<CollectionName[]> ListCollections()
    {
        var response = await HttpClient.GetFromJsonAsync("/collections", SerializerContext.Default.StringArray).ConfigureAwait(false);
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <param name="source"></param>
    public async Task CreateCollection(CollectionName name, IndexName source)
    {
        var request = new CreateCollectionRequest { Name = name, Source = source };
        var response = await HttpClient.PostAsJsonAsync(
            "/collections", request, SerializerContext.Default.CreateCollectionRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    /// <returns></returns>
    public async Task<CollectionDetails> DescribeCollection(CollectionName name)
    {
        return await HttpClient.GetFromJsonAsync(
            $"/collections/{name.Value}",
            SerializerContext.Default.CollectionDetails).ConfigureAwait(false)
                ?? ThrowHelpers.JsonException<CollectionDetails>();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="name"></param>
    public async Task DeleteCollection(CollectionName name) =>
        await (await HttpClient.DeleteAsync(new Uri($"/collections/{name.Value}")).ConfigureAwait(false)).CheckStatusCode().ConfigureAwait(false);
}

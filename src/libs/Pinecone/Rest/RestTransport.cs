using System.Net.Http.Json;
using System.Text;
using System.Text.Encodings.Web;
using CommunityToolkit.Diagnostics;

namespace Pinecone.Rest;

/// <inheritdoc cref="ITransport"/>
public readonly record struct RestTransport : ITransport
{
    private readonly HttpClient Http;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="host"></param>
    /// <param name="apiKey"></param>
    public RestTransport(string host, string apiKey)
    {
        Guard.IsNotNullOrWhiteSpace(host);
        Guard.IsNotNullOrWhiteSpace(apiKey);

        Http = new HttpClient { BaseAddress = new($"https://{host}") };
        Http.DefaultRequestHeaders.Add(Constants.RestApiKey, apiKey);
    }

    /// <inheritdoc/>
    public async Task<IndexStats> DescribeStats(MetadataMap? filter = null)
    {
        var request = new DescribeStatsRequest { Filter = filter };
        var response = await Http.PostAsJsonAsync(
            "/describe_index_stats", request, SerializerContext.Default.DescribeStatsRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);
        
        return await response.Content.ReadFromJsonAsync(SerializerContext.Default.IndexStats).ConfigureAwait(false)
            ?? ThrowHelpers.JsonException<IndexStats>();
    }

    /// <inheritdoc/>
    public async Task<ScoredVector[]> Query(
        string? id,
        float[]? values,
        SparseVector? sparseValues,
        uint topK,
        MetadataMap? filter,
        string? indexNamespace,
        bool includeValues,
        bool includeMetadata)
    {
        if (id is null && values is null && sparseValues is null)
        {
            ThrowHelper.ThrowArgumentException(
                "At least one of the following parameters must be non-null: id, values, sparseValues");
        }

        var request = new QueryRequest
        {
            Id = id,
            Vector = values,
            SparseVector = sparseValues,
            TopK = topK,
            Filter = filter,
            Namespace = indexNamespace ?? "",
            IncludeMetadata = includeMetadata,
            IncludeValues = includeValues,
        };

        var response = await Http.PostAsJsonAsync(
            "/query", request, SerializerContext.Default.QueryRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);
        
        return (await response.Content.ReadFromJsonAsync(SerializerContext.Default.QueryResponse).ConfigureAwait(false))
            .Matches ?? ThrowHelpers.JsonException<ScoredVector[]>();
    }

    /// <inheritdoc/>
    public async Task<uint> Upsert(IEnumerable<Vector> vectors, string? indexNamespace = null)
    {
        var request = new UpsertRequest
        {
            Vectors = vectors as Vector[] ?? vectors.ToArray(),
            Namespace = indexNamespace ?? "",
        };

        var response = await Http.PostAsJsonAsync("/vectors/upsert", request, SerializerContext.Default.UpsertRequest).ConfigureAwait(false);

        await response.CheckStatusCode().ConfigureAwait(false);

        var upsertResponse = await response.Content.ReadFromJsonAsync(SerializerContext.Default.UpsertResponse)
            .ConfigureAwait(false);
        
        return upsertResponse.UpsertedCount;
    }

    /// <inheritdoc/>
    public async Task Update(Vector vector, string? indexNamespace = null)
    {
        vector = vector ?? throw new ArgumentNullException(nameof(vector));
        
        var request = UpdateRequest.From(vector, indexNamespace);
        var response = await Http.PostAsJsonAsync("/vectors/update", request, SerializerContext.Default.UpdateRequest).ConfigureAwait(false);
        await response.CheckStatusCode().ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public async Task<Dictionary<string, Vector>> Fetch(
        IEnumerable<string> ids, string? indexNamespace = null)
    {
        ids = ids ?? throw new ArgumentNullException(nameof(ids));
        
        using var enumerator = ids.GetEnumerator();
        if (!enumerator.MoveNext())
        {
            ThrowHelper.ThrowArgumentException(nameof(ids), "Must contain at least one id");
        }

        var addressBuilder = new StringBuilder("/vectors/fetch")
            .Append("?ids=")
            .Append(UrlEncoder.Default.Encode(enumerator.Current));

        while (enumerator.MoveNext())
        {
            addressBuilder.Append("&ids=").Append(UrlEncoder.Default.Encode(enumerator.Current));
        }

        return (await Http.GetFromJsonAsync(
            addressBuilder.ToString(), SerializerContext.Default.FetchResponse).ConfigureAwait(false))
                .Vectors;
    }

    /// <inheritdoc/>
    public Task Delete(IEnumerable<string> ids, string? indexNamespace = null) =>
        Delete(new()
        {
            Ids = ids as string[] ?? ids.ToArray(),
            DeleteAll = false,
            Namespace = indexNamespace ?? ""
        });

    /// <inheritdoc/>
    public Task Delete(MetadataMap filter, string? indexNamespace = null) =>
        Delete(new()
        {
            Filter = filter,
            DeleteAll = false,
            Namespace = indexNamespace ?? ""
        });

    /// <inheritdoc/>
    public Task DeleteAll(string? indexNamespace = null) =>
        Delete(new() { DeleteAll = true, Namespace = indexNamespace ?? "" });

    private async Task Delete(DeleteRequest request)
    {
        var response = await Http.PostAsJsonAsync("/vectors/delete", request, SerializerContext.Default.DeleteRequest).ConfigureAwait(false);
        await response.CheckStatusCode().ConfigureAwait(false);
    }

    /// <inheritdoc/>
    public void Dispose() => Http.Dispose();
}

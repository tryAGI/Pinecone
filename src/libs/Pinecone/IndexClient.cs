namespace Pinecone;

public sealed class IndexClient<TTransport>(Index index, TTransport transport) : IDisposable
    where TTransport : ITransport
{
    internal Index Index { get; } = index;
    internal TTransport Transport { get; } = transport;

    public Task<IndexStats> DescribeStats(MetadataMap? filter = null)
    {
        return Transport.DescribeStats(filter);
    }

    public Task<ScoredVector[]> Query(
        string id,
        uint topK,
        MetadataMap? filter = null,
        string? indexNamespace = null,
        bool includeValues = true,
        bool includeMetadata = false)
    {
        return Transport.Query(
            id: id,
            values: null,
            sparseValues: null,
            topK: topK,
            filter: filter,
            indexNamespace: indexNamespace,
            includeValues: includeValues,
            includeMetadata: includeMetadata);
    }

    public Task<ScoredVector[]> Query(
        float[] values,
        uint topK,
        MetadataMap? filter = null,
        SparseVector? sparseValues = null,
        string? indexNamespace = null,
        bool includeValues = true,
        bool includeMetadata = false)
    {
        return Transport.Query(
            id: null,
            values: values,
            sparseValues: sparseValues,
            topK: topK,
            filter: filter,
            indexNamespace: indexNamespace,
            includeValues: includeValues,
            includeMetadata: includeMetadata);
    }

    public Task<uint> Upsert(IEnumerable<Vector> vectors, string? indexNamespace = null)
    {
        return Transport.Upsert(vectors, indexNamespace);
    }

    public Task Update(Vector vector, string? indexNamespace = null)
    {
        return Transport.Update(vector, indexNamespace);
    }

    public Task<Dictionary<string, Vector>> Fetch(IEnumerable<string> ids, string? indexNamespace = null)
    {
        return Transport.Fetch(ids, indexNamespace);
    }

    public Task Delete(IEnumerable<string> ids, string? indexNamespace = null)
    {
        return Transport.Delete(ids, indexNamespace);
    }

    public Task Delete(MetadataMap filter, string? indexNamespace = null)
    {
        return Transport.Delete(filter, indexNamespace);
    }

    public Task DeleteAll(string? indexNamespace = null)
    {
        return Transport.DeleteAll(indexNamespace);
    }

    public void Dispose() => Transport.Dispose();
}
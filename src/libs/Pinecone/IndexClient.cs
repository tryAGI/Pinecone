namespace Pinecone;

/// <summary>
/// 
/// </summary>
/// <param name="index"></param>
/// <param name="transport"></param>
/// <typeparam name="TTransport"></typeparam>
public sealed class IndexClient<TTransport>(Index index, TTransport transport) : IDisposable
    where TTransport : ITransport
{
    /// <summary>
    /// 
    /// </summary>
    public Index Index { get; } = index;
    
    /// <summary>
    /// 
    /// </summary>
    public TTransport Transport { get; } = transport;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    public Task<IndexStats> DescribeStats(MetadataMap? filter = null)
    {
        return Transport.DescribeStats(filter);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="topK"></param>
    /// <param name="filter"></param>
    /// <param name="indexNamespace"></param>
    /// <param name="includeValues"></param>
    /// <param name="includeMetadata"></param>
    /// <returns></returns>
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="values"></param>
    /// <param name="topK"></param>
    /// <param name="filter"></param>
    /// <param name="sparseValues"></param>
    /// <param name="indexNamespace"></param>
    /// <param name="includeValues"></param>
    /// <param name="includeMetadata"></param>
    /// <returns></returns>
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

    /// <summary>
    /// 
    /// </summary>
    /// <param name="vectors"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task<uint> Upsert(IEnumerable<Vector> vectors, string? indexNamespace = null)
    {
        return Transport.Upsert(vectors, indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task Update(Vector vector, string? indexNamespace = null)
    {
        return Transport.Update(vector, indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task<Dictionary<string, Vector>> Fetch(IEnumerable<string> ids, string? indexNamespace = null)
    {
        return Transport.Fetch(ids, indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task Delete(IEnumerable<string> ids, string? indexNamespace = null)
    {
        return Transport.Delete(ids, indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task Delete(MetadataMap filter, string? indexNamespace = null)
    {
        return Transport.Delete(filter, indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    public Task DeleteAll(string? indexNamespace = null)
    {
        return Transport.DeleteAll(indexNamespace);
    }

    /// <summary>
    /// 
    /// </summary>
    public void Dispose() => Transport.Dispose();
}
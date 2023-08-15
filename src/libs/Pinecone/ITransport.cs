namespace Pinecone;

/// <summary>
/// 
/// </summary>
public interface ITransport : IDisposable
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    Task<IndexStats> DescribeStats(MetadataMap? filter = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="values"></param>
    /// <param name="sparseValues"></param>
    /// <param name="topK"></param>
    /// <param name="filter"></param>
    /// <param name="indexNamespace"></param>
    /// <param name="includeValues"></param>
    /// <param name="includeMetadata"></param>
    /// <returns></returns>
    Task<ScoredVector[]> Query(
        string? id,
        float[]? values,
        SparseVector? sparseValues,
        uint topK,
        MetadataMap? filter,
        string? indexNamespace,
        bool includeValues,
        bool includeMetadata);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="vectors"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task<uint> Upsert(IEnumerable<Vector> vectors, string? indexNamespace = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="vector"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task Update(Vector vector, string? indexNamespace = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task<Dictionary<string, Vector>> Fetch(IEnumerable<string> ids, string? indexNamespace = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="ids"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task Delete(IEnumerable<string> ids, string? indexNamespace = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task Delete(MetadataMap filter, string? indexNamespace = null);
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="indexNamespace"></param>
    /// <returns></returns>
    Task DeleteAll(string? indexNamespace = null);
}

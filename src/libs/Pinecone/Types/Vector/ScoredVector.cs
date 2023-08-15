namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record ScoredVector
{
    /// <summary>
    /// 
    /// </summary>
    public required string Id { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required double Score { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public float[]? Values { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public SparseVector? SparseValues { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public MetadataMap? Metadata { get; init; }
}
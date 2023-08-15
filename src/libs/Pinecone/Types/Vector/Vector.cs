namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record Vector
{
    /// <summary>
    /// 
    /// </summary>
    public required string Id { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required float[] Values { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public SparseVector? SparseValues { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public MetadataMap? Metadata { get; init; }
}
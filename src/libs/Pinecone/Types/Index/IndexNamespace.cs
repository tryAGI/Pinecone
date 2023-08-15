namespace Pinecone;

/// <summary>
/// 
/// </summary>
public readonly record struct IndexNamespace
{
    /// <summary>
    /// 
    /// </summary>
    public required string Name { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required uint VectorCount { get; init; }
}

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record CollectionDetails
{
    /// <summary>
    /// 
    /// </summary>
    public required string Name { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required uint Size { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required string Status { get; init; }
}

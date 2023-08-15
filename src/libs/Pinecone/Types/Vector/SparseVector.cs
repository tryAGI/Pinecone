namespace Pinecone;

/// <summary>
/// 
/// </summary>
public readonly record struct SparseVector
{
    /// <summary>
    /// 
    /// </summary>
    public required uint[] Indices { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required float[] Values { get; init; }
}
namespace Pinecone;

/// <summary>
/// 
/// </summary>
/// <param name="Value"></param>
public readonly record struct IndexName(string Value)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator string(IndexName value) => value.Value;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator IndexName(string value) => new(value);
}
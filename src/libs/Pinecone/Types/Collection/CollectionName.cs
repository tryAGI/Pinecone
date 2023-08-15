namespace Pinecone;

/// <summary>
/// 
/// </summary>
/// <param name="Value"></param>
public readonly record struct CollectionName(string Value)
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator string(CollectionName value) => value.Value;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static implicit operator CollectionName(string value) => new(value);
}
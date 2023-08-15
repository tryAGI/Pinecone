#if NETSTANDARD2_0 || NET462_OR_GREATER
namespace Pinecone;

/// <summary>
/// 
/// </summary>
public static class KeyValuePairExtensions
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="tuple"></param>
    /// <param name="key"></param>
    /// <param name="value"></param>
    /// <typeparam name="T1"></typeparam>
    /// <typeparam name="T2"></typeparam>
    public static void Deconstruct<T1, T2>(this KeyValuePair<T1, T2> tuple, out T1 key, out T2 value)
    {
        key = tuple.Key;
        value = tuple.Value;
    }
}
#endif
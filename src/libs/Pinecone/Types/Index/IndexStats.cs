using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record IndexStats
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(IndexNamespaceArrayConverter))]
    public required IndexNamespace[] Namespaces { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required uint Dimension { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required float IndexFullness { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required uint TotalVectorCount { get; init; }
}
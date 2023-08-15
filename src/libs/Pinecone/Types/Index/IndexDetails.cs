using System.Text.Json.Serialization;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record IndexDetails
{
    /// <summary>
    /// 
    /// </summary>
    public required string Name { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required uint Dimension { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required Metric Metric { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public long? Pods { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("pod_type")]
    public string? PodType { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public long? Replicas { get; init; }
}
using System.Text.Json.Serialization;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record IndexStatus
{
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("ready")]
    public required bool IsReady { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required IndexState State { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public required string Host { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public string?[]? Waiting { get; init; }
    
    /// <summary>
    /// 
    /// </summary>
    public string?[]? Crashed { get; init; }
}
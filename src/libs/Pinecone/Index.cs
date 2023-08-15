using System.Text.Json.Serialization;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
public record Index
{
    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("database")]
    public required IndexDetails Details { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("status")]
    public required IndexStatus Status { get; init; }

    /// <summary>
    /// 
    /// </summary>
    [JsonPropertyName("metadata_config")]
    public MetadataMap? MetadataConfig { get; init; }
}
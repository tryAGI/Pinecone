using System.Text.Json.Serialization;

namespace Pinecone;

// Contract
public record Index
{
    [JsonPropertyName("database")]
    public required IndexDetails Details { get; init; }

    [JsonPropertyName("status")]
    public required IndexStatus Status { get; init; }

    [JsonPropertyName("metadata_config")]
    public MetadataMap? MetadataConfig { get; init; }
}
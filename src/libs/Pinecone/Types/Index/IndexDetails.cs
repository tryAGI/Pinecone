using System.Text.Json.Serialization;

namespace Pinecone;

public record IndexDetails
{
    public required string Name { get; init; }
    public required uint Dimension { get; init; }
    public required Metric Metric { get; init; }
    public long? Pods { get; init; }
    [JsonPropertyName("pod_type")]
    public string? PodType { get; init; }
    public long? Replicas { get; init; }
}
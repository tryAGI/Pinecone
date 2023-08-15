using System.Text.Json.Serialization;

namespace Pinecone;

public record IndexStatus
{
    [JsonPropertyName("ready")]
    public required bool IsReady { get; init; }
    public required IndexState State { get; init; }
    public required string Host { get; init; }
    public string?[]? Waiting { get; init; }
    public string?[]? Crashed { get; init; }
}
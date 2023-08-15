using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

public record IndexStats
{
    [JsonConverter(typeof(IndexNamespaceArrayConverter))]
    public required IndexNamespace[] Namespaces { get; init; }
    public required uint Dimension { get; init; }
    public required float IndexFullness { get; init; }
    public required uint TotalVectorCount { get; init; }
}
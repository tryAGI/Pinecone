namespace Pinecone;

public readonly record struct IndexNamespace
{
    public required string Name { get; init; }
    public required uint VectorCount { get; init; }
}

namespace Pinecone;

public readonly record struct SparseVector
{
    public required uint[] Indices { get; init; }
    public required float[] Values { get; init; }
}
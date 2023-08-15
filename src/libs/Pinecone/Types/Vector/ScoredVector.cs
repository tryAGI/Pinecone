namespace Pinecone;

public record ScoredVector
{
    public required string Id { get; init; }
    public required double Score { get; init; }
    public float[]? Values { get; init; }
    public SparseVector? SparseValues { get; init; }
    public MetadataMap? Metadata { get; init; }
}
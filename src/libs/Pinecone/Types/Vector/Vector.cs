namespace Pinecone;

public record Vector
{
    public required string Id { get; init; }
    public required float[] Values { get; init; }
    public SparseVector? SparseValues { get; init; }
    public MetadataMap? Metadata { get; init; }
}
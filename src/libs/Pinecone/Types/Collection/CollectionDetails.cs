namespace Pinecone;

public record CollectionDetails
{
    public required string Name { get; init; }
    public required uint Size { get; init; }
    public required string Status { get; init; }
}

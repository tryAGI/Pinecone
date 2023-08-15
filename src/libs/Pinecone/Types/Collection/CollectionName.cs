namespace Pinecone;

public readonly record struct CollectionName(string Value)
{
    public static implicit operator string(CollectionName value) => value.Value;
    public static implicit operator CollectionName(string value) => new(value);
}
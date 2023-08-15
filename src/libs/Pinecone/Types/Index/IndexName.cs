namespace Pinecone;

public readonly record struct IndexName(string Value)
{
    public static implicit operator string(IndexName value) => value.Value;
    public static implicit operator IndexName(string value) => new(value);
}
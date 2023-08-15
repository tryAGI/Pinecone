using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

[JsonConverter(typeof(MetadataValueConverter))]
public readonly record struct MetadataValue
{
    public object? Inner { get; }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    internal MetadataValue(object? value) => Inner = value;

    public static implicit operator MetadataValue(bool value) => new(value);
    public static implicit operator MetadataValue(string? value) => new(value);
    public static implicit operator MetadataValue(int value) => new((double)value);
    public static implicit operator MetadataValue(long value) => new((double)value);
    public static implicit operator MetadataValue(float value) => new((double)value);
    public static implicit operator MetadataValue(double value) => new(value);
    public static implicit operator MetadataValue(decimal value) => new((double)value);
    public static implicit operator MetadataValue(MetadataMap value) => new(value);
    public static implicit operator MetadataValue(MetadataValue[]? value) => new(value);
#pragma warning disable CA1002
    public static implicit operator MetadataValue(List<MetadataValue>? value) => new(value);
#pragma warning restore CA1002
}

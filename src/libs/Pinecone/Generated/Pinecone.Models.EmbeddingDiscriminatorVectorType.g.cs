
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public enum EmbeddingDiscriminatorVectorType
    {
        /// <summary>
        /// 
        /// </summary>
        Dense,
        /// <summary>
        /// 
        /// </summary>
        Sparse,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EmbeddingDiscriminatorVectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EmbeddingDiscriminatorVectorType value)
        {
            return value switch
            {
                EmbeddingDiscriminatorVectorType.Dense => "dense",
                EmbeddingDiscriminatorVectorType.Sparse => "sparse",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EmbeddingDiscriminatorVectorType? ToEnum(string value)
        {
            return value switch
            {
                "dense" => EmbeddingDiscriminatorVectorType.Dense,
                "sparse" => EmbeddingDiscriminatorVectorType.Sparse,
                _ => null,
            };
        }
    }
}
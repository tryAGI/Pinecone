#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public class EmbeddingJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.Embedding>
    {
        /// <inheritdoc />
        public override global::Pinecone.Embedding Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.EmbeddingDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.EmbeddingDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.EmbeddingDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Pinecone.DenseEmbedding? dense = default;
            if (discriminator?.VectorType == global::Pinecone.EmbeddingDiscriminatorVectorType.Dense)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.DenseEmbedding), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.DenseEmbedding> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.DenseEmbedding)}");
                dense = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Pinecone.SparseEmbedding? sparse = default;
            if (discriminator?.VectorType == global::Pinecone.EmbeddingDiscriminatorVectorType.Sparse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.SparseEmbedding), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.SparseEmbedding> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.SparseEmbedding)}");
                sparse = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Pinecone.Embedding(
                discriminator?.VectorType,
                dense,

                sparse
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.Embedding value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsDense)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.DenseEmbedding), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.DenseEmbedding?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.DenseEmbedding).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dense!, typeInfo);
            }
            else if (value.IsSparse)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.SparseEmbedding), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.SparseEmbedding?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.SparseEmbedding).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Sparse!, typeInfo);
            }
        }
    }
}
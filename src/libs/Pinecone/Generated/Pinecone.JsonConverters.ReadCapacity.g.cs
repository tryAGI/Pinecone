#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public class ReadCapacityJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.ReadCapacity>
    {
        /// <inheritdoc />
        public override global::Pinecone.ReadCapacity Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Pinecone.ReadCapacityOnDemandSpec? onDemand = default;
            if (discriminator?.Mode == global::Pinecone.ReadCapacityDiscriminatorMode.OnDemand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityOnDemandSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityOnDemandSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityOnDemandSpec)}");
                onDemand = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Pinecone.ReadCapacityDedicatedSpec? dedicated = default;
            if (discriminator?.Mode == global::Pinecone.ReadCapacityDiscriminatorMode.Dedicated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityDedicatedSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityDedicatedSpec> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityDedicatedSpec)}");
                dedicated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Pinecone.ReadCapacity(
                discriminator?.Mode,
                onDemand,

                dedicated
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.ReadCapacity value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOnDemand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityOnDemandSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityOnDemandSpec?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.ReadCapacityOnDemandSpec).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OnDemand, typeInfo);
            }
            else if (value.IsDedicated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityDedicatedSpec), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityDedicatedSpec?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.ReadCapacityDedicatedSpec).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dedicated, typeInfo);
            }
        }
    }
}
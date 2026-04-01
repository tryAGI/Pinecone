#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public class ReadCapacityResponseJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.ReadCapacityResponse>
    {
        /// <inheritdoc />
        public override global::Pinecone.ReadCapacityResponse Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            var readerCopy = reader;
            var discriminatorTypeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityResponseDiscriminator), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityResponseDiscriminator> ??
                            throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityResponseDiscriminator)}");
            var discriminator = global::System.Text.Json.JsonSerializer.Deserialize(ref readerCopy, discriminatorTypeInfo);

            global::Pinecone.ReadCapacityOnDemandSpecResponse? onDemand = default;
            if (discriminator?.Mode == global::Pinecone.ReadCapacityResponseDiscriminatorMode.OnDemand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityOnDemandSpecResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityOnDemandSpecResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityOnDemandSpecResponse)}");
                onDemand = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }
            global::Pinecone.ReadCapacityDedicatedSpecResponse? dedicated = default;
            if (discriminator?.Mode == global::Pinecone.ReadCapacityResponseDiscriminatorMode.Dedicated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityDedicatedSpecResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityDedicatedSpecResponse> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {nameof(global::Pinecone.ReadCapacityDedicatedSpecResponse)}");
                dedicated = global::System.Text.Json.JsonSerializer.Deserialize(ref reader, typeInfo);
            }

            var __value = new global::Pinecone.ReadCapacityResponse(
                discriminator?.Mode,
                onDemand,

                dedicated
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.ReadCapacityResponse value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsOnDemand)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityOnDemandSpecResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityOnDemandSpecResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.ReadCapacityOnDemandSpecResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.OnDemand!, typeInfo);
            }
            else if (value.IsDedicated)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Pinecone.ReadCapacityDedicatedSpecResponse), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Pinecone.ReadCapacityDedicatedSpecResponse?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Pinecone.ReadCapacityDedicatedSpecResponse).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Dedicated!, typeInfo);
            }
        }
    }
}
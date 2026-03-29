#nullable enable

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadCapacityDiscriminatorModeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.ReadCapacityDiscriminatorMode>
    {
        /// <inheritdoc />
        public override global::Pinecone.ReadCapacityDiscriminatorMode Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Pinecone.ReadCapacityDiscriminatorModeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Pinecone.ReadCapacityDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Pinecone.ReadCapacityDiscriminatorMode);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.ReadCapacityDiscriminatorMode value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Pinecone.ReadCapacityDiscriminatorModeExtensions.ToValueString(value));
        }
    }
}

#nullable enable

namespace Pinecone.JsonConverters
{
    /// <inheritdoc />
    public sealed class ReadCapacityResponseDiscriminatorModeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Pinecone.ReadCapacityResponseDiscriminatorMode?>
    {
        /// <inheritdoc />
        public override global::Pinecone.ReadCapacityResponseDiscriminatorMode? Read(
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
                        return global::Pinecone.ReadCapacityResponseDiscriminatorModeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Pinecone.ReadCapacityResponseDiscriminatorMode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Pinecone.ReadCapacityResponseDiscriminatorMode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Pinecone.ReadCapacityResponseDiscriminatorMode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Pinecone.ReadCapacityResponseDiscriminatorModeExtensions.ToValueString(value.Value));
            }
        }
    }
}

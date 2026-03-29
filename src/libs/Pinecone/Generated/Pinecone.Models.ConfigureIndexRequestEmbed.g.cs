
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configure the integrated inference embedding settings for this index.<br/>
    /// You can convert an existing index to an integrated index by specifying the embedding model and field_map. The index vector type and dimension must match the model vector type and dimension, and the index similarity metric must be supported by the model. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
    /// You can later change the embedding configuration to update the field map, read parameters, or write parameters. Once set, the model cannot be changed.<br/>
    /// Example: {"field_map":{"text":"your-text-field"},"model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
    /// </summary>
    public sealed partial class ConfigureIndexRequestEmbed
    {
        /// <summary>
        /// The name of the embedding model to use with the index. The index dimension and model dimension must match, and the index similarity metric must be supported by the model. The index embedding model cannot be changed once set.<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// Identifies the name of the text field from your document model that will be embedded.<br/>
        /// Example: {"text":"your-text-field"}
        /// </summary>
        /// <example>{"text":"your-text-field"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_map")]
        public object? FieldMap { get; set; }

        /// <summary>
        /// The read parameters for the embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_parameters")]
        public object? ReadParameters { get; set; }

        /// <summary>
        /// The write parameters for the embedding model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("write_parameters")]
        public object? WriteParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestEmbed" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the embedding model to use with the index. The index dimension and model dimension must match, and the index similarity metric must be supported by the model. The index embedding model cannot be changed once set.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="fieldMap">
        /// Identifies the name of the text field from your document model that will be embedded.<br/>
        /// Example: {"text":"your-text-field"}
        /// </param>
        /// <param name="readParameters">
        /// The read parameters for the embedding model.
        /// </param>
        /// <param name="writeParameters">
        /// The write parameters for the embedding model.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequestEmbed(
            string? model,
            object? fieldMap,
            object? readParameters,
            object? writeParameters)
        {
            this.Model = model;
            this.FieldMap = fieldMap;
            this.ReadParameters = readParameters;
            this.WriteParameters = writeParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestEmbed" /> class.
        /// </summary>
        public ConfigureIndexRequestEmbed()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Specify the integrated inference embedding configuration for the index.<br/>
    /// Once set the model cannot be changed, but you can later update the embedding configuration for an integrated inference index including field map, read parameters, or write parameters.<br/>
    /// Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
    /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
    /// </summary>
    public sealed partial class CreateIndexForModelRequestEmbed
    {
        /// <summary>
        /// The name of the embedding model to use for the index.<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If not specified, the metric will be defaulted according to the model. Cannot be updated once set.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string? Metric { get; set; }

        /// <summary>
        /// Identifies the name of the text field from your document model that will be embedded.<br/>
        /// Example: {"text":"your-text-field"}
        /// </summary>
        /// <example>{"text":"your-text-field"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("field_map")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object FieldMap { get; set; }

        /// <summary>
        /// The dimension of embedding vectors produced for the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateIndexForModelRequestEmbed" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the embedding model to use for the index.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="fieldMap">
        /// Identifies the name of the text field from your document model that will be embedded.<br/>
        /// Example: {"text":"your-text-field"}
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If not specified, the metric will be defaulted according to the model. Cannot be updated once set.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </param>
        /// <param name="dimension">
        /// The dimension of embedding vectors produced for the index.
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
        public CreateIndexForModelRequestEmbed(
            string model,
            object fieldMap,
            string? metric,
            int? dimension,
            object? readParameters,
            object? writeParameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Metric = metric;
            this.FieldMap = fieldMap ?? throw new global::System.ArgumentNullException(nameof(fieldMap));
            this.Dimension = dimension;
            this.ReadParameters = readParameters;
            this.WriteParameters = writeParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexForModelRequestEmbed" /> class.
        /// </summary>
        public CreateIndexForModelRequestEmbed()
        {
        }
    }
}
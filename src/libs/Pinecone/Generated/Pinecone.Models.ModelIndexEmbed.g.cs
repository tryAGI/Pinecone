
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The embedding model and document fields mapped to embedding inputs.<br/>
    /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
    /// </summary>
    public sealed partial class ModelIndexEmbed
    {
        /// <summary>
        /// The name of the embedding model used to create the index.<br/>
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
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        public string? VectorType { get; set; }

        /// <summary>
        /// Identifies the name of the text field from your document model that is embedded.<br/>
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
        /// Initializes a new instance of the <see cref="ModelIndexEmbed" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the embedding model used to create the index.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If not specified, the metric will be defaulted according to the model. Cannot be updated once set.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </param>
        /// <param name="dimension">
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="vectorType">
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </param>
        /// <param name="fieldMap">
        /// Identifies the name of the text field from your document model that is embedded.<br/>
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
        public ModelIndexEmbed(
            string model,
            string? metric,
            int? dimension,
            string? vectorType,
            object? fieldMap,
            object? readParameters,
            object? writeParameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Metric = metric;
            this.Dimension = dimension;
            this.VectorType = vectorType;
            this.FieldMap = fieldMap;
            this.ReadParameters = readParameters;
            this.WriteParameters = writeParameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelIndexEmbed" /> class.
        /// </summary>
        public ModelIndexEmbed()
        {
        }
    }
}
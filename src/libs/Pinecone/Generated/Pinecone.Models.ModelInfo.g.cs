
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Represents the model configuration including model type, supported parameters, and other model details.
    /// </summary>
    public sealed partial class ModelInfo
    {
        /// <summary>
        /// The name of the model.<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// A summary of the model.<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("short_description")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ShortDescription { get; set; }

        /// <summary>
        /// The type of model (e.g. 'embed' or 'rerank').<br/>
        /// Example: embed
        /// </summary>
        /// <example>embed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Whether the embedding model produces 'dense' or 'sparse' embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        public string? VectorType { get; set; }

        /// <summary>
        /// The default embedding model dimension (applies to dense embedding models only).<br/>
        /// Example: 1024
        /// </summary>
        /// <example>1024</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default_dimension")]
        public int? DefaultDimension { get; set; }

        /// <summary>
        /// The modality of the model (e.g. 'text').<br/>
        /// Example: text
        /// </summary>
        /// <example>text</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("modality")]
        public string? Modality { get; set; }

        /// <summary>
        /// The maximum tokens per sequence supported by the model.<br/>
        /// Example: 512
        /// </summary>
        /// <example>512</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sequence_length")]
        public int? MaxSequenceLength { get; set; }

        /// <summary>
        /// The maximum batch size (number of sequences) supported by the model.<br/>
        /// Example: 96
        /// </summary>
        /// <example>96</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_batch_size")]
        public int? MaxBatchSize { get; set; }

        /// <summary>
        /// The name of the provider of the model.<br/>
        /// Example: NVIDIA
        /// </summary>
        /// <example>NVIDIA</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider_name")]
        public string? ProviderName { get; set; }

        /// <summary>
        /// The list of supported dimensions for the model (applies to dense embedding models only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_dimensions")]
        public global::System.Collections.Generic.IList<int>? SupportedDimensions { get; set; }

        /// <summary>
        /// The distance metrics supported by the model for similarity search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_metrics")]
        public global::System.Collections.Generic.IList<string>? SupportedMetrics { get; set; }

        /// <summary>
        /// List of parameters supported by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("supported_parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.ModelInfoSupportedParameter> SupportedParameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        /// <param name="model">
        /// The name of the model.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="shortDescription">
        /// A summary of the model.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="type">
        /// The type of model (e.g. 'embed' or 'rerank').<br/>
        /// Example: embed
        /// </param>
        /// <param name="supportedParameters">
        /// List of parameters supported by the model.
        /// </param>
        /// <param name="vectorType">
        /// Whether the embedding model produces 'dense' or 'sparse' embeddings.
        /// </param>
        /// <param name="defaultDimension">
        /// The default embedding model dimension (applies to dense embedding models only).<br/>
        /// Example: 1024
        /// </param>
        /// <param name="modality">
        /// The modality of the model (e.g. 'text').<br/>
        /// Example: text
        /// </param>
        /// <param name="maxSequenceLength">
        /// The maximum tokens per sequence supported by the model.<br/>
        /// Example: 512
        /// </param>
        /// <param name="maxBatchSize">
        /// The maximum batch size (number of sequences) supported by the model.<br/>
        /// Example: 96
        /// </param>
        /// <param name="providerName">
        /// The name of the provider of the model.<br/>
        /// Example: NVIDIA
        /// </param>
        /// <param name="supportedDimensions">
        /// The list of supported dimensions for the model (applies to dense embedding models only).
        /// </param>
        /// <param name="supportedMetrics">
        /// The distance metrics supported by the model for similarity search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfo(
            string model,
            string shortDescription,
            string type,
            global::System.Collections.Generic.IList<global::Pinecone.ModelInfoSupportedParameter> supportedParameters,
            string? vectorType,
            int? defaultDimension,
            string? modality,
            int? maxSequenceLength,
            int? maxBatchSize,
            string? providerName,
            global::System.Collections.Generic.IList<int>? supportedDimensions,
            global::System.Collections.Generic.IList<string>? supportedMetrics)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.ShortDescription = shortDescription ?? throw new global::System.ArgumentNullException(nameof(shortDescription));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.VectorType = vectorType;
            this.DefaultDimension = defaultDimension;
            this.Modality = modality;
            this.MaxSequenceLength = maxSequenceLength;
            this.MaxBatchSize = maxBatchSize;
            this.ProviderName = providerName;
            this.SupportedDimensions = supportedDimensions;
            this.SupportedMetrics = supportedMetrics;
            this.SupportedParameters = supportedParameters ?? throw new global::System.ArgumentNullException(nameof(supportedParameters));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfo" /> class.
        /// </summary>
        public ModelInfo()
        {
        }
    }
}
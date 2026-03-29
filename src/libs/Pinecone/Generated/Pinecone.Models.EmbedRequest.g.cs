
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedRequest
    {
        /// <summary>
        /// The [model](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) to use for embedding generation.<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available model parameters.<br/>
        /// Example: {"input_type":"passage","truncate":"END"}
        /// </summary>
        /// <example>{"input_type":"passage","truncate":"END"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// List of inputs to generate embeddings for.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.EmbedRequestInput> Inputs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The [model](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) to use for embedding generation.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="inputs">
        /// List of inputs to generate embeddings for.
        /// </param>
        /// <param name="parameters">
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available model parameters.<br/>
        /// Example: {"input_type":"passage","truncate":"END"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedRequest(
            string model,
            global::System.Collections.Generic.IList<global::Pinecone.EmbedRequestInput> inputs,
            object? parameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Parameters = parameters;
            this.Inputs = inputs ?? throw new global::System.ArgumentNullException(nameof(inputs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRequest" /> class.
        /// </summary>
        public EmbedRequest()
        {
        }
    }
}
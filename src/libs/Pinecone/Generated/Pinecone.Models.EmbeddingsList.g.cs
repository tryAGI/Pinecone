
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Embeddings generated for the input.
    /// </summary>
    public sealed partial class EmbeddingsList
    {
        /// <summary>
        /// The model used to generate the embeddings<br/>
        /// Example: multilingual-e5-large
        /// </summary>
        /// <example>multilingual-e5-large</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Indicates whether the response data contains 'dense' or 'sparse' embeddings.<br/>
        /// Example: dense
        /// </summary>
        /// <example>dense</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorType { get; set; }

        /// <summary>
        /// The embeddings generated for the inputs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.Embedding> Data { get; set; }

        /// <summary>
        /// Usage statistics for the model inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.EmbeddingsListUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsList" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used to generate the embeddings<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="vectorType">
        /// Indicates whether the response data contains 'dense' or 'sparse' embeddings.<br/>
        /// Example: dense
        /// </param>
        /// <param name="data">
        /// The embeddings generated for the inputs.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the model inference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsList(
            string model,
            string vectorType,
            global::System.Collections.Generic.IList<global::Pinecone.Embedding> data,
            global::Pinecone.EmbeddingsListUsage usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.VectorType = vectorType ?? throw new global::System.ArgumentNullException(nameof(vectorType));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsList" /> class.
        /// </summary>
        public EmbeddingsList()
        {
        }
    }
}
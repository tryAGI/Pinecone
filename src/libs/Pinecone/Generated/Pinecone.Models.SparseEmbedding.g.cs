
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// A sparse embedding of a single input
    /// </summary>
    public sealed partial class SparseEmbedding
    {
        /// <summary>
        /// The sparse embedding values.<br/>
        /// Example: [0.1, 0.2, 0.3]
        /// </summary>
        /// <example>[0.1, 0.2, 0.3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> SparseValues { get; set; }

        /// <summary>
        /// The sparse embedding indices.<br/>
        /// Example: [10, 3, 156]
        /// </summary>
        /// <example>[10, 3, 156]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_indices")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<long> SparseIndices { get; set; }

        /// <summary>
        /// The normalized tokens used to create the sparse embedding.<br/>
        /// Example: [quick, brown, fox]
        /// </summary>
        /// <example>[quick, brown, fox]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("sparse_tokens")]
        public global::System.Collections.Generic.IList<string>? SparseTokens { get; set; }

        /// <summary>
        /// Indicates whether this is a 'dense' or 'sparse' embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseEmbedding" /> class.
        /// </summary>
        /// <param name="sparseValues">
        /// The sparse embedding values.<br/>
        /// Example: [0.1, 0.2, 0.3]
        /// </param>
        /// <param name="sparseIndices">
        /// The sparse embedding indices.<br/>
        /// Example: [10, 3, 156]
        /// </param>
        /// <param name="vectorType">
        /// Indicates whether this is a 'dense' or 'sparse' embedding.
        /// </param>
        /// <param name="sparseTokens">
        /// The normalized tokens used to create the sparse embedding.<br/>
        /// Example: [quick, brown, fox]
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SparseEmbedding(
            global::System.Collections.Generic.IList<float> sparseValues,
            global::System.Collections.Generic.IList<long> sparseIndices,
            string vectorType,
            global::System.Collections.Generic.IList<string>? sparseTokens)
        {
            this.SparseValues = sparseValues ?? throw new global::System.ArgumentNullException(nameof(sparseValues));
            this.SparseIndices = sparseIndices ?? throw new global::System.ArgumentNullException(nameof(sparseIndices));
            this.SparseTokens = sparseTokens;
            this.VectorType = vectorType ?? throw new global::System.ArgumentNullException(nameof(vectorType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SparseEmbedding" /> class.
        /// </summary>
        public SparseEmbedding()
        {
        }
    }
}
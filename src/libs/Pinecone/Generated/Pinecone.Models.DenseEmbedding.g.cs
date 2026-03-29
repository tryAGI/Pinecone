
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// A dense embedding of a single input
    /// </summary>
    public sealed partial class DenseEmbedding
    {
        /// <summary>
        /// The dense embedding values.<br/>
        /// Example: [0.1, 0.2, 0.3]
        /// </summary>
        /// <example>[0.1, 0.2, 0.3]</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<float> Values { get; set; }

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
        /// Initializes a new instance of the <see cref="DenseEmbedding" /> class.
        /// </summary>
        /// <param name="values">
        /// The dense embedding values.<br/>
        /// Example: [0.1, 0.2, 0.3]
        /// </param>
        /// <param name="vectorType">
        /// Indicates whether this is a 'dense' or 'sparse' embedding.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DenseEmbedding(
            global::System.Collections.Generic.IList<float> values,
            string vectorType)
        {
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
            this.VectorType = vectorType ?? throw new global::System.ArgumentNullException(nameof(vectorType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DenseEmbedding" /> class.
        /// </summary>
        public DenseEmbedding()
        {
        }
    }
}
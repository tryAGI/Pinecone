
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbeddingDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.EmbeddingDiscriminatorVectorTypeJsonConverter))]
        public global::Pinecone.EmbeddingDiscriminatorVectorType? VectorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingDiscriminator" /> class.
        /// </summary>
        /// <param name="vectorType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingDiscriminator(
            global::Pinecone.EmbeddingDiscriminatorVectorType? vectorType)
        {
            this.VectorType = vectorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingDiscriminator" /> class.
        /// </summary>
        public EmbeddingDiscriminator()
        {
        }
    }
}
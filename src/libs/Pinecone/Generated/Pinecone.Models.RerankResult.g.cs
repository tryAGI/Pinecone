
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The result of a reranking request.
    /// </summary>
    public sealed partial class RerankResult
    {
        /// <summary>
        /// The model used to rerank documents.<br/>
        /// Example: bge-reranker-v2-m3
        /// </summary>
        /// <example>bge-reranker-v2-m3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The reranked documents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.RankedDocument> Data { get; set; }

        /// <summary>
        /// Usage statistics for the model inference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.RerankResultUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        /// <param name="model">
        /// The model used to rerank documents.<br/>
        /// Example: bge-reranker-v2-m3
        /// </param>
        /// <param name="data">
        /// The reranked documents.
        /// </param>
        /// <param name="usage">
        /// Usage statistics for the model inference.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResult(
            string model,
            global::System.Collections.Generic.IList<global::Pinecone.RankedDocument> data,
            global::Pinecone.RerankResultUsage usage)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResult" /> class.
        /// </summary>
        public RerankResult()
        {
        }
    }
}
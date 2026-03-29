
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// A ranked document with a relevance score and an index position.
    /// </summary>
    public sealed partial class RankedDocument
    {
        /// <summary>
        /// The index position of the document from the original request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The relevance of the document to the query, normalized between 0 and 1, with scores closer to 1 indicating higher relevance.<br/>
        /// Example: 0.5
        /// </summary>
        /// <example>0.5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Score { get; set; }

        /// <summary>
        /// Document for reranking<br/>
        /// Example: {"id":"1","text":"Paris is the capital of France.","title":"France","url":"https://example.com"}
        /// </summary>
        /// <example>{"id":"1","text":"Paris is the capital of France.","title":"France","url":"https://example.com"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("document")]
        public global::Pinecone.Document? Document { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        /// <param name="index">
        /// The index position of the document from the original request.
        /// </param>
        /// <param name="score">
        /// The relevance of the document to the query, normalized between 0 and 1, with scores closer to 1 indicating higher relevance.<br/>
        /// Example: 0.5
        /// </param>
        /// <param name="document">
        /// Document for reranking<br/>
        /// Example: {"id":"1","text":"Paris is the capital of France.","title":"France","url":"https://example.com"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RankedDocument(
            int index,
            double score,
            global::Pinecone.Document? document)
        {
            this.Index = index;
            this.Score = score;
            this.Document = document;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RankedDocument" /> class.
        /// </summary>
        public RankedDocument()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RerankRequest
    {
        /// <summary>
        /// The [model](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) to use for reranking.<br/>
        /// Example: bge-reranker-v2-m3
        /// </summary>
        /// <example>bge-reranker-v2-m3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The query to rerank documents against.<br/>
        /// Example: What is the capital of France?
        /// </summary>
        /// <example>What is the capital of France?</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The number of results to return sorted by relevance. Defaults to the number of inputs.<br/>
        /// Example: 5
        /// </summary>
        /// <example>5</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("top_n")]
        public int? TopN { get; set; }

        /// <summary>
        /// Whether to return the documents in the response.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("return_documents")]
        public bool? ReturnDocuments { get; set; }

        /// <summary>
        /// The field(s) to consider for reranking. If not provided, the default is `["text"]`.<br/>
        /// The number of fields supported is [model-specific](https://docs.pinecone.io/guides/search/rerank-results#reranking-models).<br/>
        /// Default Value: [text]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rank_fields")]
        public global::System.Collections.Generic.IList<string>? RankFields { get; set; }

        /// <summary>
        /// The documents to rerank.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documents")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.Document> Documents { get; set; }

        /// <summary>
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) for available model parameters.<br/>
        /// Example: {"truncate":"END"}
        /// </summary>
        /// <example>{"truncate":"END"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        public object? Parameters { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        /// <param name="model">
        /// The [model](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) to use for reranking.<br/>
        /// Example: bge-reranker-v2-m3
        /// </param>
        /// <param name="query">
        /// The query to rerank documents against.<br/>
        /// Example: What is the capital of France?
        /// </param>
        /// <param name="documents">
        /// The documents to rerank.
        /// </param>
        /// <param name="topN">
        /// The number of results to return sorted by relevance. Defaults to the number of inputs.<br/>
        /// Example: 5
        /// </param>
        /// <param name="returnDocuments">
        /// Whether to return the documents in the response.<br/>
        /// Default Value: true<br/>
        /// Example: true
        /// </param>
        /// <param name="rankFields">
        /// The field(s) to consider for reranking. If not provided, the default is `["text"]`.<br/>
        /// The number of fields supported is [model-specific](https://docs.pinecone.io/guides/search/rerank-results#reranking-models).<br/>
        /// Default Value: [text]
        /// </param>
        /// <param name="parameters">
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) for available model parameters.<br/>
        /// Example: {"truncate":"END"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankRequest(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::Pinecone.Document> documents,
            int? topN,
            bool? returnDocuments,
            global::System.Collections.Generic.IList<string>? rankFields,
            object? parameters)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.TopN = topN;
            this.ReturnDocuments = returnDocuments;
            this.RankFields = rankFields;
            this.Documents = documents ?? throw new global::System.ArgumentNullException(nameof(documents));
            this.Parameters = parameters;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankRequest" /> class.
        /// </summary>
        public RerankRequest()
        {
        }
    }
}
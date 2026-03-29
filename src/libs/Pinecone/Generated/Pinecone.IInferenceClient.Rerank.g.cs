#nullable enable

namespace Pinecone
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Rerank results<br/>
        /// Rerank results according to their relevance to a query.<br/>
        /// For guidance and examples, see [Rerank results](https://docs.pinecone.io/guides/search/rerank-results).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.RerankResult> RerankAsync(

            global::Pinecone.RerankRequest request,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Rerank results<br/>
        /// Rerank results according to their relevance to a query.<br/>
        /// For guidance and examples, see [Rerank results](https://docs.pinecone.io/guides/search/rerank-results).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="model">
        /// The [model](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) to use for reranking.<br/>
        /// Example: bge-reranker-v2-m3
        /// </param>
        /// <param name="query">
        /// The query to rerank documents against.<br/>
        /// Example: What is the capital of France?
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
        /// <param name="documents">
        /// The documents to rerank.
        /// </param>
        /// <param name="parameters">
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) for available model parameters.<br/>
        /// Example: {"truncate":"END"}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.RerankResult> RerankAsync(
            string model,
            string query,
            global::System.Collections.Generic.IList<global::Pinecone.Document> documents,
            string xPineconeApiVersion = "2026-04",
            int? topN = default,
            bool? returnDocuments = default,
            global::System.Collections.Generic.IList<string>? rankFields = default,
            object? parameters = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Pinecone
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// List available models<br/>
        /// List the embedding and reranking models hosted by Pinecone. <br/>
        /// You can use hosted models as an integrated part of Pinecone operations or for standalone embedding and reranking. For more details, see [Vector embedding](https://docs.pinecone.io/guides/index-data/indexing-overview#vector-embedding) and [Rerank results](https://docs.pinecone.io/guides/search/rerank-results).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="type">
        /// Filter models by type.<br/>
        /// Possible values: `embed` or `rerank`.
        /// </param>
        /// <param name="vectorType">
        /// Filter models by vector type.<br/>
        /// Possible values: `dense` or `sparse`.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.ModelInfoList> ListModelsAsync(
            string xPineconeApiVersion = "2026-04",
            string? type = default,
            string? vectorType = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
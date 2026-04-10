#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// List collections<br/>
        /// List all collections in a project.<br/>
        /// Serverless indexes do not support collections.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.CollectionList> ListCollectionsAsync(
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
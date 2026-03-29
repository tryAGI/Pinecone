#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Describe an index<br/>
        /// Get a description of an index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> DescribeIndexAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
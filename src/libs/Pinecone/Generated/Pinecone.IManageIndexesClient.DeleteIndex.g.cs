#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Delete an index<br/>
        /// Delete an existing index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task DeleteIndexAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
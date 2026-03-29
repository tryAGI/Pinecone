#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Describe a collection<br/>
        /// Get a description of a collection.<br/>
        /// Serverless indexes do not support collections.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="collectionName"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.CollectionModel> DescribeCollectionAsync(
            string collectionName,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
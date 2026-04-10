#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Create a backup of an index<br/>
        /// Create a backup of an index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupModel> CreateBackupAsync(
            string indexName,

            global::Pinecone.CreateBackupRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a backup of an index<br/>
        /// Create a backup of an index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="name">
        /// The name of the backup.
        /// </param>
        /// <param name="description">
        /// A description of the backup.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupModel> CreateBackupAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            string? name = default,
            string? description = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
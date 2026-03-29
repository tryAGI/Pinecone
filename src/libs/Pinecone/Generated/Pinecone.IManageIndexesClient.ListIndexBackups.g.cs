#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// List backups for an index<br/>
        /// List all backups for an index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="paginationToken"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupList> ListIndexBackupsAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            int? limit = default,
            string? paginationToken = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
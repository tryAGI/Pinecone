#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// List backup schedules for an index<br/>
        /// Return backup schedules associated with the given index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="paginationToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupScheduleList> ListBackupSchedulesAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            int? limit = default,
            string? paginationToken = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List backup schedules for an index<br/>
        /// Return backup schedules associated with the given index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="limit">
        /// Default Value: 10
        /// </param>
        /// <param name="paginationToken"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.AutoSDKHttpResponse<global::Pinecone.BackupScheduleList>> ListBackupSchedulesAsResponseAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            int? limit = default,
            string? paginationToken = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
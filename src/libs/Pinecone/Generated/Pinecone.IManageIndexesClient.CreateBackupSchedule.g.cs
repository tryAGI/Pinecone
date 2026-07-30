#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Create a backup schedule for an index<br/>
        /// Create a time-based backup schedule for the specified index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupScheduleResponse> CreateBackupScheduleAsync(
            string indexName,

            global::Pinecone.CreateBackupScheduleRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a backup schedule for an index<br/>
        /// Create a time-based backup schedule for the specified index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.AutoSDKHttpResponse<global::Pinecone.BackupScheduleResponse>> CreateBackupScheduleAsResponseAsync(
            string indexName,

            global::Pinecone.CreateBackupScheduleRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a backup schedule for an index<br/>
        /// Create a time-based backup schedule for the specified index.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="name">
        /// User-defined name for the backup schedule.<br/>
        /// Example: daily-compliance-backup
        /// </param>
        /// <param name="schedule">
        /// Time-based schedule configuration for automatic index backups. Only time-based schedules are supported.
        /// </param>
        /// <param name="retention">
        /// Retention policy for backups created by this schedule. Backups older than the retention window may be removed.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupScheduleResponse> CreateBackupScheduleAsync(
            string indexName,
            string name,
            global::Pinecone.BackupScheduleRequestSchedule schedule,
            global::Pinecone.BackupScheduleRetentionInput retention,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
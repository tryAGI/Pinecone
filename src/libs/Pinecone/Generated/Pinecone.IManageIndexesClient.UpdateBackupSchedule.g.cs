#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Update a backup schedule<br/>
        /// Update frequency, retention, or enabled state for a backup schedule.<br/>
        /// Re-enabling a disabled schedule (`enabled: true`) enqueues a new backup operation.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="scheduleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupScheduleResponse> UpdateBackupScheduleAsync(
            string scheduleId,

            global::Pinecone.UpdateBackupScheduleRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a backup schedule<br/>
        /// Update frequency, retention, or enabled state for a backup schedule.<br/>
        /// Re-enabling a disabled schedule (`enabled: true`) enqueues a new backup operation.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="scheduleId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.AutoSDKHttpResponse<global::Pinecone.BackupScheduleResponse>> UpdateBackupScheduleAsResponseAsync(
            string scheduleId,

            global::Pinecone.UpdateBackupScheduleRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a backup schedule<br/>
        /// Update frequency, retention, or enabled state for a backup schedule.<br/>
        /// Re-enabling a disabled schedule (`enabled: true`) enqueues a new backup operation.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="scheduleId"></param>
        /// <param name="frequency">
        /// How often the scheduled backup runs.<br/>
        /// Example: weekly
        /// </param>
        /// <param name="retention">
        /// Retention policy for backups created by this schedule. Backups older than the retention window may be removed.
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is active. Setting to `true` after a disable re-enqueues backup processing.<br/>
        /// Example: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.BackupScheduleResponse> UpdateBackupScheduleAsync(
            string scheduleId,
            string xPineconeApiVersion = "2026-04",
            string? frequency = default,
            global::Pinecone.BackupScheduleRetentionInput? retention = default,
            bool? enabled = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The RestoreJobModel describes the status of a restore job.
    /// </summary>
    public sealed partial class RestoreJobModel
    {
        /// <summary>
        /// Unique identifier for the restore job<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RestoreJobId { get; set; }

        /// <summary>
        /// Backup used for the restore<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackupId { get; set; }

        /// <summary>
        /// Name of the index into which data is being restored<br/>
        /// Example: sample-index
        /// </summary>
        /// <example>sample-index</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetIndexName { get; set; }

        /// <summary>
        /// ID of the index<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440002
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetIndexId { get; set; }

        /// <summary>
        /// Status of the restore job<br/>
        /// Example: Completed
        /// </summary>
        /// <example>Completed</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Timestamp when the restore job started<br/>
        /// Example: 2025-02-04 13:00:00+00:00
        /// </summary>
        /// <example>2025-02-04 13:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Timestamp when the restore job finished<br/>
        /// Example: 2025-02-04 14:00:00+00:00
        /// </summary>
        /// <example>2025-02-04 14:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("completed_at")]
        public global::System.DateTime? CompletedAt { get; set; }

        /// <summary>
        /// The progress made by the restore job out of 100<br/>
        /// Example: 42.2
        /// </summary>
        /// <example>42.2</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("percent_complete")]
        public float? PercentComplete { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreJobModel" /> class.
        /// </summary>
        /// <param name="restoreJobId">
        /// Unique identifier for the restore job<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440001
        /// </param>
        /// <param name="backupId">
        /// Backup used for the restore<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="targetIndexName">
        /// Name of the index into which data is being restored<br/>
        /// Example: sample-index
        /// </param>
        /// <param name="targetIndexId">
        /// ID of the index<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440002
        /// </param>
        /// <param name="status">
        /// Status of the restore job<br/>
        /// Example: Completed
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the restore job started<br/>
        /// Example: 2025-02-04 13:00:00+00:00
        /// </param>
        /// <param name="completedAt">
        /// Timestamp when the restore job finished<br/>
        /// Example: 2025-02-04 14:00:00+00:00
        /// </param>
        /// <param name="percentComplete">
        /// The progress made by the restore job out of 100<br/>
        /// Example: 42.2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RestoreJobModel(
            string restoreJobId,
            string backupId,
            string targetIndexName,
            string targetIndexId,
            string status,
            global::System.DateTime createdAt,
            global::System.DateTime? completedAt,
            float? percentComplete)
        {
            this.RestoreJobId = restoreJobId ?? throw new global::System.ArgumentNullException(nameof(restoreJobId));
            this.BackupId = backupId ?? throw new global::System.ArgumentNullException(nameof(backupId));
            this.TargetIndexName = targetIndexName ?? throw new global::System.ArgumentNullException(nameof(targetIndexName));
            this.TargetIndexId = targetIndexId ?? throw new global::System.ArgumentNullException(nameof(targetIndexId));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.CreatedAt = createdAt;
            this.CompletedAt = completedAt;
            this.PercentComplete = percentComplete;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RestoreJobModel" /> class.
        /// </summary>
        public RestoreJobModel()
        {
        }
    }
}
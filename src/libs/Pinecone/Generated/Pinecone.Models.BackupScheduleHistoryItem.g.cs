
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// A backup produced by a schedule, including lifecycle status. When `status` is `Scheduled`, `scheduled_execution_at` is set to the planned run time.
    /// </summary>
    public sealed partial class BackupScheduleHistoryItem
    {
        /// <summary>
        /// Unique identifier for the backup.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </summary>
        /// <example>a1b2c3d4-e5f6-7890-abcd-ef1234567890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackupId { get; set; }

        /// <summary>
        /// ID of the index from which the backup was taken.<br/>
        /// Example: 8cbf7ba6-4135-438e-a3c3-4a89a3298905
        /// </summary>
        /// <example>8cbf7ba6-4135-438e-a3c3-4a89a3298905</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceIndexId { get; set; }

        /// <summary>
        /// Name of the index from which the backup was taken.<br/>
        /// Example: my-index
        /// </summary>
        /// <example>my-index</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceIndexName { get; set; }

        /// <summary>
        /// Custom user tags on this backup snapshot. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'. Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string. `null` when no tags are set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Name of the backup.<br/>
        /// Example: daily-compliance-backup-20260403T060000Z
        /// </summary>
        /// <example>daily-compliance-backup-20260403T060000Z</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of the backup, or `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Current lifecycle status of the backup.<br/>
        /// Example: Ready
        /// </summary>
        /// <example>Ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Cloud provider where the backup is stored.<br/>
        /// Example: aws
        /// </summary>
        /// <example>aws</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cloud { get; set; }

        /// <summary>
        /// Cloud region where the backup is stored.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Dimension { get; set; }

        /// <summary>
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// Metadata schema associated with the backup, or `null` if not applicable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::Pinecone.MetadataSchema? Schema { get; set; }

        /// <summary>
        /// Total number of records in the backup.<br/>
        /// Example: 500000
        /// </summary>
        /// <example>500000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long RecordCount { get; set; }

        /// <summary>
        /// Number of namespaces in the backup.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int NamespaceCount { get; set; }

        /// <summary>
        /// Approximate stored size of this scheduled-backup snapshot, in bytes.<br/>
        /// Example: 104857600
        /// </summary>
        /// <example>104857600</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when the backup record was created.<br/>
        /// Example: 2026-04-03 06:00:00+00:00
        /// </summary>
        /// <example>2026-04-03 06:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Present when `status` is `Scheduled`. RFC 3339 timestamp when the backup is planned to run.<br/>
        /// Example: 2026-04-04 06:00:00+00:00
        /// </summary>
        /// <example>2026-04-04 06:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduled_execution_at")]
        public global::System.DateTime? ScheduledExecutionAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleHistoryItem" /> class.
        /// </summary>
        /// <param name="backupId">
        /// Unique identifier for the backup.<br/>
        /// Example: a1b2c3d4-e5f6-7890-abcd-ef1234567890
        /// </param>
        /// <param name="sourceIndexId">
        /// ID of the index from which the backup was taken.<br/>
        /// Example: 8cbf7ba6-4135-438e-a3c3-4a89a3298905
        /// </param>
        /// <param name="sourceIndexName">
        /// Name of the index from which the backup was taken.<br/>
        /// Example: my-index
        /// </param>
        /// <param name="name">
        /// Name of the backup.<br/>
        /// Example: daily-compliance-backup-20260403T060000Z
        /// </param>
        /// <param name="status">
        /// Current lifecycle status of the backup.<br/>
        /// Example: Ready
        /// </param>
        /// <param name="cloud">
        /// Cloud provider where the backup is stored.<br/>
        /// Example: aws
        /// </param>
        /// <param name="region">
        /// Cloud region where the backup is stored.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="dimension">
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </param>
        /// <param name="recordCount">
        /// Total number of records in the backup.<br/>
        /// Example: 500000
        /// </param>
        /// <param name="namespaceCount">
        /// Number of namespaces in the backup.<br/>
        /// Example: 1
        /// </param>
        /// <param name="sizeBytes">
        /// Approximate stored size of this scheduled-backup snapshot, in bytes.<br/>
        /// Example: 104857600
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 timestamp when the backup record was created.<br/>
        /// Example: 2026-04-03 06:00:00+00:00
        /// </param>
        /// <param name="tags">
        /// Custom user tags on this backup snapshot. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'. Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string. `null` when no tags are set.
        /// </param>
        /// <param name="description">
        /// Optional description of the backup, or `null`.
        /// </param>
        /// <param name="schema">
        /// Metadata schema associated with the backup, or `null` if not applicable.
        /// </param>
        /// <param name="scheduledExecutionAt">
        /// Present when `status` is `Scheduled`. RFC 3339 timestamp when the backup is planned to run.<br/>
        /// Example: 2026-04-04 06:00:00+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleHistoryItem(
            string backupId,
            string sourceIndexId,
            string sourceIndexName,
            string name,
            string status,
            string cloud,
            string region,
            int dimension,
            string metric,
            long recordCount,
            int namespaceCount,
            long sizeBytes,
            global::System.DateTime createdAt,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            string? description,
            global::Pinecone.MetadataSchema? schema,
            global::System.DateTime? scheduledExecutionAt)
        {
            this.BackupId = backupId ?? throw new global::System.ArgumentNullException(nameof(backupId));
            this.SourceIndexId = sourceIndexId ?? throw new global::System.ArgumentNullException(nameof(sourceIndexId));
            this.SourceIndexName = sourceIndexName ?? throw new global::System.ArgumentNullException(nameof(sourceIndexName));
            this.Tags = tags;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Cloud = cloud ?? throw new global::System.ArgumentNullException(nameof(cloud));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Dimension = dimension;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Schema = schema;
            this.RecordCount = recordCount;
            this.NamespaceCount = namespaceCount;
            this.SizeBytes = sizeBytes;
            this.CreatedAt = createdAt;
            this.ScheduledExecutionAt = scheduledExecutionAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleHistoryItem" /> class.
        /// </summary>
        public BackupScheduleHistoryItem()
        {
        }

    }
}
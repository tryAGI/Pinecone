
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Describes a backup schedule for an index.
    /// </summary>
    public sealed partial class BackupScheduleResponse
    {
        /// <summary>
        /// Unique identifier for the backup schedule.<br/>
        /// Example: e88f7273-42aa-47e9-af73-593827136867
        /// </summary>
        /// <example>e88f7273-42aa-47e9-af73-593827136867</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleId { get; set; }

        /// <summary>
        /// User-defined name for the backup schedule.<br/>
        /// Example: daily-compliance-backup
        /// </summary>
        /// <example>daily-compliance-backup</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// ID of the index this schedule backs up.<br/>
        /// Example: 8cbf7ba6-4135-438e-a3c3-4a89a3298905
        /// </summary>
        /// <example>8cbf7ba6-4135-438e-a3c3-4a89a3298905</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// Pinecone project that contains this schedule (same project as the source index).<br/>
        /// Example: 71ce31ea-75f7-45d6-a147-ef67f661a1b0
        /// </summary>
        /// <example>71ce31ea-75f7-45d6-a147-ef67f661a1b0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// Schedule category. Only time-based schedules are supported.<br/>
        /// Example: time-based
        /// </summary>
        /// <example>time-based</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ScheduleType { get; set; }

        /// <summary>
        /// How often the scheduled backup runs.<br/>
        /// Example: daily
        /// </summary>
        /// <example>daily</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Frequency { get; set; }

        /// <summary>
        /// Number of days backups created by this schedule are retained.<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention_expire_after_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int RetentionExpireAfterDays { get; set; }

        /// <summary>
        /// Whether the schedule is active. Disabled schedules do not run.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Enabled { get; set; }

        /// <summary>
        /// Always present. RFC 3339 timestamp of the next planned backup run when `enabled` is `true`. `null` when `enabled` is `false`; no backup is scheduled until the schedule is re-enabled.<br/>
        /// Example: 2026-04-03 06:00:00+00:00
        /// </summary>
        /// <example>2026-04-03 06:00:00+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next_scheduled_run")]
        public global::System.DateTime? NextScheduledRun { get; set; }

        /// <summary>
        /// RFC 3339 timestamp when the schedule was created.<br/>
        /// Example: 2026-04-02 18:22:56.712605+00:00
        /// </summary>
        /// <example>2026-04-02 18:22:56.712605+00:00</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleResponse" /> class.
        /// </summary>
        /// <param name="scheduleId">
        /// Unique identifier for the backup schedule.<br/>
        /// Example: e88f7273-42aa-47e9-af73-593827136867
        /// </param>
        /// <param name="name">
        /// User-defined name for the backup schedule.<br/>
        /// Example: daily-compliance-backup
        /// </param>
        /// <param name="indexId">
        /// ID of the index this schedule backs up.<br/>
        /// Example: 8cbf7ba6-4135-438e-a3c3-4a89a3298905
        /// </param>
        /// <param name="projectId">
        /// Pinecone project that contains this schedule (same project as the source index).<br/>
        /// Example: 71ce31ea-75f7-45d6-a147-ef67f661a1b0
        /// </param>
        /// <param name="scheduleType">
        /// Schedule category. Only time-based schedules are supported.<br/>
        /// Example: time-based
        /// </param>
        /// <param name="frequency">
        /// How often the scheduled backup runs.<br/>
        /// Example: daily
        /// </param>
        /// <param name="retentionExpireAfterDays">
        /// Number of days backups created by this schedule are retained.<br/>
        /// Example: 90
        /// </param>
        /// <param name="enabled">
        /// Whether the schedule is active. Disabled schedules do not run.<br/>
        /// Example: true
        /// </param>
        /// <param name="createdAt">
        /// RFC 3339 timestamp when the schedule was created.<br/>
        /// Example: 2026-04-02 18:22:56.712605+00:00
        /// </param>
        /// <param name="nextScheduledRun">
        /// Always present. RFC 3339 timestamp of the next planned backup run when `enabled` is `true`. `null` when `enabled` is `false`; no backup is scheduled until the schedule is re-enabled.<br/>
        /// Example: 2026-04-03 06:00:00+00:00
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleResponse(
            string scheduleId,
            string name,
            string indexId,
            string projectId,
            string scheduleType,
            string frequency,
            int retentionExpireAfterDays,
            bool enabled,
            global::System.DateTime createdAt,
            global::System.DateTime? nextScheduledRun)
        {
            this.ScheduleId = scheduleId ?? throw new global::System.ArgumentNullException(nameof(scheduleId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ScheduleType = scheduleType ?? throw new global::System.ArgumentNullException(nameof(scheduleType));
            this.Frequency = frequency ?? throw new global::System.ArgumentNullException(nameof(frequency));
            this.RetentionExpireAfterDays = retentionExpireAfterDays;
            this.Enabled = enabled;
            this.NextScheduledRun = nextScheduledRun;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleResponse" /> class.
        /// </summary>
        public BackupScheduleResponse()
        {
        }

    }
}
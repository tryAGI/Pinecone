
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Request body for creating a backup schedule on an index.
    /// </summary>
    public sealed partial class CreateBackupScheduleRequest
    {
        /// <summary>
        /// User-defined name for the backup schedule.<br/>
        /// Example: daily-compliance-backup
        /// </summary>
        /// <example>daily-compliance-backup</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Time-based schedule configuration for automatic index backups. Only time-based schedules are supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schedule")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.BackupScheduleRequestSchedule Schedule { get; set; }

        /// <summary>
        /// Retention policy for backups created by this schedule. Backups older than the retention window may be removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.BackupScheduleRetentionInput Retention { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBackupScheduleRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBackupScheduleRequest(
            string name,
            global::Pinecone.BackupScheduleRequestSchedule schedule,
            global::Pinecone.BackupScheduleRetentionInput retention)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Schedule = schedule ?? throw new global::System.ArgumentNullException(nameof(schedule));
            this.Retention = retention ?? throw new global::System.ArgumentNullException(nameof(retention));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBackupScheduleRequest" /> class.
        /// </summary>
        public CreateBackupScheduleRequest()
        {
        }

    }
}
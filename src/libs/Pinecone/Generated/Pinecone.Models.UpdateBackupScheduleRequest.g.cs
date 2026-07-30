
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Fields that can be updated on an existing backup schedule. Omitted fields are left unchanged. Re-enabling a disabled schedule (`enabled: true`) enqueues a new backup operation.
    /// </summary>
    public sealed partial class UpdateBackupScheduleRequest
    {
        /// <summary>
        /// How often the scheduled backup runs.<br/>
        /// Example: weekly
        /// </summary>
        /// <example>weekly</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("frequency")]
        public string? Frequency { get; set; }

        /// <summary>
        /// Retention policy for backups created by this schedule. Backups older than the retention window may be removed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retention")]
        public global::Pinecone.BackupScheduleRetentionInput? Retention { get; set; }

        /// <summary>
        /// Whether the schedule is active. Setting to `true` after a disable re-enqueues backup processing.<br/>
        /// Example: false
        /// </summary>
        /// <example>false</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBackupScheduleRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateBackupScheduleRequest(
            string? frequency,
            global::Pinecone.BackupScheduleRetentionInput? retention,
            bool? enabled)
        {
            this.Frequency = frequency;
            this.Retention = retention;
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateBackupScheduleRequest" /> class.
        /// </summary>
        public UpdateBackupScheduleRequest()
        {
        }

    }
}
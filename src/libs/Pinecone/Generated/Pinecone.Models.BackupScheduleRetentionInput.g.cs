
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Retention policy for backups created by this schedule. Backups older than the retention window may be removed.
    /// </summary>
    public sealed partial class BackupScheduleRetentionInput
    {
        /// <summary>
        /// Number of days to retain each backup created by this schedule. The maximum allowed value is determined by your project configuration (`max_backup_retention_days`).<br/>
        /// Example: 90
        /// </summary>
        /// <example>90</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("expire_after_days")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ExpireAfterDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleRetentionInput" /> class.
        /// </summary>
        /// <param name="expireAfterDays">
        /// Number of days to retain each backup created by this schedule. The maximum allowed value is determined by your project configuration (`max_backup_retention_days`).<br/>
        /// Example: 90
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleRetentionInput(
            int expireAfterDays)
        {
            this.ExpireAfterDays = expireAfterDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleRetentionInput" /> class.
        /// </summary>
        public BackupScheduleRetentionInput()
        {
        }

    }
}
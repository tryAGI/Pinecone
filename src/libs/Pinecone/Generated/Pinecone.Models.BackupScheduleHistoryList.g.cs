
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Paginated list of backups created by a specific backup schedule.
    /// </summary>
    public sealed partial class BackupScheduleHistoryList
    {
        /// <summary>
        /// Backups from this schedule for the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.BackupScheduleHistoryItem> Data { get; set; }

        /// <summary>
        /// Cursor envelope for the next page. `null` (or absent) on the final page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::Pinecone.BackupScheduleHistoryListPagination2? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleHistoryList" /> class.
        /// </summary>
        /// <param name="data">
        /// Backups from this schedule for the current page.
        /// </param>
        /// <param name="pagination">
        /// Cursor envelope for the next page. `null` (or absent) on the final page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleHistoryList(
            global::System.Collections.Generic.IList<global::Pinecone.BackupScheduleHistoryItem> data,
            global::Pinecone.BackupScheduleHistoryListPagination2? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleHistoryList" /> class.
        /// </summary>
        public BackupScheduleHistoryList()
        {
        }

    }
}
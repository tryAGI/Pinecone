
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Paginated list of backup schedules for an index.
    /// </summary>
    public sealed partial class BackupScheduleList
    {
        /// <summary>
        /// Backup schedules returned for this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Pinecone.BackupScheduleResponse> Data { get; set; }

        /// <summary>
        /// Cursor envelope for the next page. `null` (or absent) on the final page of results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::Pinecone.BackupScheduleListPagination2? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleList" /> class.
        /// </summary>
        /// <param name="data">
        /// Backup schedules returned for this page.
        /// </param>
        /// <param name="pagination">
        /// Cursor envelope for the next page. `null` (or absent) on the final page of results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupScheduleList(
            global::System.Collections.Generic.IList<global::Pinecone.BackupScheduleResponse> data,
            global::Pinecone.BackupScheduleListPagination2? pagination)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleList" /> class.
        /// </summary>
        public BackupScheduleList()
        {
        }

    }
}
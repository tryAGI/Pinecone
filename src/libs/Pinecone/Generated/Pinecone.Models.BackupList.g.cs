
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The list of backups that exist in the project.
    /// </summary>
    public sealed partial class BackupList
    {
        /// <summary>
        /// List of backup objects
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::System.Collections.Generic.IList<global::Pinecone.BackupModel>? Data { get; set; }

        /// <summary>
        /// The pagination object that is returned with paginated responses.<br/>
        /// Example: {"next":"dXNlcl9pZD11c2VyXzE="}
        /// </summary>
        /// <example>{"next":"dXNlcl9pZD11c2VyXzE="}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        public global::Pinecone.PaginationResponse? Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupList" /> class.
        /// </summary>
        /// <param name="data">
        /// List of backup objects
        /// </param>
        /// <param name="pagination">
        /// The pagination object that is returned with paginated responses.<br/>
        /// Example: {"next":"dXNlcl9pZD11c2VyXzE="}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupList(
            global::System.Collections.Generic.IList<global::Pinecone.BackupModel>? data,
            global::Pinecone.PaginationResponse? pagination)
        {
            this.Data = data;
            this.Pagination = pagination;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupList" /> class.
        /// </summary>
        public BackupList()
        {
        }
    }
}
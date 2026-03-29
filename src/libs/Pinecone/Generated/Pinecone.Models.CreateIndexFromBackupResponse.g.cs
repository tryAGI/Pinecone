
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The response for creating an index from a backup.
    /// </summary>
    public sealed partial class CreateIndexFromBackupResponse
    {
        /// <summary>
        /// The ID of the restore job that was created.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("restore_job_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RestoreJobId { get; set; }

        /// <summary>
        /// The ID of the index that was created from the backup.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </summary>
        /// <example>123e4567-e89b-12d3-a456-426614174000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string IndexId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexFromBackupResponse" /> class.
        /// </summary>
        /// <param name="restoreJobId">
        /// The ID of the restore job that was created.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="indexId">
        /// The ID of the index that was created from the backup.<br/>
        /// Example: 123e4567-e89b-12d3-a456-426614174000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIndexFromBackupResponse(
            string restoreJobId,
            string indexId)
        {
            this.RestoreJobId = restoreJobId ?? throw new global::System.ArgumentNullException(nameof(restoreJobId));
            this.IndexId = indexId ?? throw new global::System.ArgumentNullException(nameof(indexId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexFromBackupResponse" /> class.
        /// </summary>
        public CreateIndexFromBackupResponse()
        {
        }
    }
}
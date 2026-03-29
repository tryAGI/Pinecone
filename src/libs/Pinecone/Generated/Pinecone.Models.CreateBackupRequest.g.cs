
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The configuration needed to create a backup of an index.
    /// </summary>
    public sealed partial class CreateBackupRequest
    {
        /// <summary>
        /// The name of the backup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A description of the backup.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBackupRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the backup.
        /// </param>
        /// <param name="description">
        /// A description of the backup.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateBackupRequest(
            string? name,
            string? description)
        {
            this.Name = name;
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateBackupRequest" /> class.
        /// </summary>
        public CreateBackupRequest()
        {
        }
    }
}
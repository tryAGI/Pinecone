
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The list of indexes that exist in the project.
    /// </summary>
    public sealed partial class IndexList
    {
        /// <summary>
        /// List of indexes in the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexes")]
        public global::System.Collections.Generic.IList<global::Pinecone.IndexModel>? Indexes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexList" /> class.
        /// </summary>
        /// <param name="indexes">
        /// List of indexes in the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexList(
            global::System.Collections.Generic.IList<global::Pinecone.IndexModel>? indexes)
        {
            this.Indexes = indexes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexList" /> class.
        /// </summary>
        public IndexList()
        {
        }
    }
}
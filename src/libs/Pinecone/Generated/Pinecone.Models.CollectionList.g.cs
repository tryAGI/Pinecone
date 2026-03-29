
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The list of collections that exist in the project.
    /// </summary>
    public sealed partial class CollectionList
    {
        /// <summary>
        /// List of collections in the project
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.IList<global::Pinecone.CollectionModel>? Collections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionList" /> class.
        /// </summary>
        /// <param name="collections">
        /// List of collections in the project
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionList(
            global::System.Collections.Generic.IList<global::Pinecone.CollectionModel>? collections)
        {
            this.Collections = collections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionList" /> class.
        /// </summary>
        public CollectionList()
        {
        }
    }
}
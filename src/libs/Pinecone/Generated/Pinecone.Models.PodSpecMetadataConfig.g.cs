
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `metadata_config` is present, only specified metadata fields are indexed. These configurations are only valid for use with pod-based indexes.<br/>
    /// Example: {"indexed":["genre","title","imdb_rating"]}
    /// </summary>
    public sealed partial class PodSpecMetadataConfig
    {
        /// <summary>
        /// By default, all metadata is indexed; to change this behavior, use this property to specify an array of metadata fields that should be indexed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("indexed")]
        public global::System.Collections.Generic.IList<string>? Indexed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodSpecMetadataConfig" /> class.
        /// </summary>
        /// <param name="indexed">
        /// By default, all metadata is indexed; to change this behavior, use this property to specify an array of metadata fields that should be indexed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PodSpecMetadataConfig(
            global::System.Collections.Generic.IList<string>? indexed)
        {
            this.Indexed = indexed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodSpecMetadataConfig" /> class.
        /// </summary>
        public PodSpecMetadataConfig()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
    /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
    /// </summary>
    public sealed partial class MetadataSchema
    {
        /// <summary>
        /// A map of metadata field names to their configuration. The field name must be a valid metadata field name. The field name must be unique.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Pinecone.MetadataSchemaFields2> Fields { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchema" /> class.
        /// </summary>
        /// <param name="fields">
        /// A map of metadata field names to their configuration. The field name must be a valid metadata field name. The field name must be unique.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSchema(
            global::System.Collections.Generic.Dictionary<string, global::Pinecone.MetadataSchemaFields2> fields)
        {
            this.Fields = fields ?? throw new global::System.ArgumentNullException(nameof(fields));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchema" /> class.
        /// </summary>
        public MetadataSchema()
        {
        }
    }
}
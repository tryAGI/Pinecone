
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// A map of metadata field names to their configuration. The field name must be a valid metadata field name. The field name must be unique.
    /// </summary>
    public sealed partial class MetadataSchemaFields
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
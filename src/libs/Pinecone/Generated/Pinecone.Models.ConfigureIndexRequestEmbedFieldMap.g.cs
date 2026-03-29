
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Identifies the name of the text field from your document model that will be embedded.<br/>
    /// Example: {"text":"your-text-field"}
    /// </summary>
    public sealed partial class ConfigureIndexRequestEmbedFieldMap
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
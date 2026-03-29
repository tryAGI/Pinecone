
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Document for reranking<br/>
    /// Example: {"id":"1","text":"Paris is the capital of France.","title":"France","url":"https://example.com"}
    /// </summary>
    public sealed partial class Document
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
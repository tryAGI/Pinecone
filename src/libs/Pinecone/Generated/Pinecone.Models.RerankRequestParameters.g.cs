
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/search/rerank-results#reranking-models) for available model parameters.<br/>
    /// Example: {"truncate":"END"}
    /// </summary>
    public sealed partial class RerankRequestParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
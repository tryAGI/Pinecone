
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Usage statistics for the model inference.
    /// </summary>
    public sealed partial class RerankResultUsage
    {
        /// <summary>
        /// The number of rerank units consumed by this operation.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("rerank_units")]
        public int? RerankUnits { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResultUsage" /> class.
        /// </summary>
        /// <param name="rerankUnits">
        /// The number of rerank units consumed by this operation.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RerankResultUsage(
            int? rerankUnits)
        {
            this.RerankUnits = rerankUnits;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RerankResultUsage" /> class.
        /// </summary>
        public RerankResultUsage()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Usage statistics for the model inference.
    /// </summary>
    public sealed partial class EmbeddingsListUsage
    {
        /// <summary>
        /// Total number of tokens consumed across all inputs.<br/>
        /// Example: 205
        /// </summary>
        /// <example>205</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsListUsage" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// Total number of tokens consumed across all inputs.<br/>
        /// Example: 205
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbeddingsListUsage(
            int? totalTokens)
        {
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddingsListUsage" /> class.
        /// </summary>
        public EmbeddingsListUsage()
        {
        }
    }
}
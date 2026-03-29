
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexModelSpecServerless
    {
        /// <summary>
        /// Configuration of a serverless index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverless")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ServerlessSpecResponse Serverless { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelSpecServerless" /> class.
        /// </summary>
        /// <param name="serverless">
        /// Configuration of a serverless index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexModelSpecServerless(
            global::Pinecone.ServerlessSpecResponse serverless)
        {
            this.Serverless = serverless ?? throw new global::System.ArgumentNullException(nameof(serverless));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelSpecServerless" /> class.
        /// </summary>
        public IndexModelSpecServerless()
        {
        }
    }
}
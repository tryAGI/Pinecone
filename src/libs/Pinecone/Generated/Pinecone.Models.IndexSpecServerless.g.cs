
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexSpecServerless
    {
        /// <summary>
        /// Configuration needed to deploy a serverless index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverless")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ServerlessSpec Serverless { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecServerless" /> class.
        /// </summary>
        /// <param name="serverless">
        /// Configuration needed to deploy a serverless index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexSpecServerless(
            global::Pinecone.ServerlessSpec serverless)
        {
            this.Serverless = serverless ?? throw new global::System.ArgumentNullException(nameof(serverless));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecServerless" /> class.
        /// </summary>
        public IndexSpecServerless()
        {
        }
    }
}
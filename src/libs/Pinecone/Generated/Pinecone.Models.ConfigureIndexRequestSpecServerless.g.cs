
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureIndexRequestSpecServerless
    {
        /// <summary>
        /// Updated configuration for serverless indexes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("serverless")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ConfigureIndexRequestSpecServerlessServerless Serverless { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecServerless" /> class.
        /// </summary>
        /// <param name="serverless">
        /// Updated configuration for serverless indexes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequestSpecServerless(
            global::Pinecone.ConfigureIndexRequestSpecServerlessServerless serverless)
        {
            this.Serverless = serverless ?? throw new global::System.ArgumentNullException(nameof(serverless));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecServerless" /> class.
        /// </summary>
        public ConfigureIndexRequestSpecServerless()
        {
        }
    }
}
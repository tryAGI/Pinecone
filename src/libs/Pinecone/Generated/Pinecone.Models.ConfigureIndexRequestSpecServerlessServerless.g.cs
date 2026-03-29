
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Updated configuration for serverless indexes
    /// </summary>
    public sealed partial class ConfigureIndexRequestSpecServerlessServerless
    {
        /// <summary>
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_capacity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityJsonConverter))]
        public global::Pinecone.ReadCapacity? ReadCapacity { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecServerlessServerless" /> class.
        /// </summary>
        /// <param name="readCapacity">
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequestSpecServerlessServerless(
            global::Pinecone.ReadCapacity? readCapacity)
        {
            this.ReadCapacity = readCapacity;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecServerlessServerless" /> class.
        /// </summary>
        public ConfigureIndexRequestSpecServerlessServerless()
        {
        }
    }
}
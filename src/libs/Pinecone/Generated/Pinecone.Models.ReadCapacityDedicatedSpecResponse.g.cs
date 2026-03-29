
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Example: {"dedicated":{"manual":{"replicas":2,"shards":2},"node_type":"t1","scaling":"Manual"},"mode":"Dedicated","status":{"current_replicas":2,"current_shards":2,"state":"Ready"}}
    /// </summary>
    public sealed partial class ReadCapacityDedicatedSpecResponse
    {
        /// <summary>
        /// The mode of the index. Possible values: `OnDemand` or `Dedicated`. Defaults to `OnDemand`. If set to `Dedicated`, `dedicated.node_type`, and `dedicated.scaling` must be specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Configuration for dedicated read capacity. See  [this guide](https://docs.pinecone.io/guides/index-data/dedicated-read-nodes) for more details on  how to configure dedicated read capacity.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dedicated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ReadCapacityDedicatedConfig Dedicated { get; set; }

        /// <summary>
        /// The current status of factors affecting the read capacity of a serverless index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ReadCapacityStatus Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityDedicatedSpecResponse" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode of the index. Possible values: `OnDemand` or `Dedicated`. Defaults to `OnDemand`. If set to `Dedicated`, `dedicated.node_type`, and `dedicated.scaling` must be specified.
        /// </param>
        /// <param name="dedicated">
        /// Configuration for dedicated read capacity. See  [this guide](https://docs.pinecone.io/guides/index-data/dedicated-read-nodes) for more details on  how to configure dedicated read capacity.
        /// </param>
        /// <param name="status">
        /// The current status of factors affecting the read capacity of a serverless index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadCapacityDedicatedSpecResponse(
            string mode,
            global::Pinecone.ReadCapacityDedicatedConfig dedicated,
            global::Pinecone.ReadCapacityStatus status)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
            this.Dedicated = dedicated ?? throw new global::System.ArgumentNullException(nameof(dedicated));
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityDedicatedSpecResponse" /> class.
        /// </summary>
        public ReadCapacityDedicatedSpecResponse()
        {
        }
    }
}
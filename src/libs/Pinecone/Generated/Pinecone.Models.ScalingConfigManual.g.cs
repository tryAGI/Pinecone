
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The config to use for manual read capacity scaling.
    /// </summary>
    public sealed partial class ScalingConfigManual
    {
        /// <summary>
        /// The number of replicas to use. Replicas duplicate the compute resources and data of an index, allowing higher query throughput and availability. Setting replicas to 0 disables the index but can be used to reduce costs while usage is paused.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// The number of shards to use. Shards determine the storage capacity of an index, with each shard providing 250 GB of storage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public int? Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigManual" /> class.
        /// </summary>
        /// <param name="replicas">
        /// The number of replicas to use. Replicas duplicate the compute resources and data of an index, allowing higher query throughput and availability. Setting replicas to 0 disables the index but can be used to reduce costs while usage is paused.
        /// </param>
        /// <param name="shards">
        /// The number of shards to use. Shards determine the storage capacity of an index, with each shard providing 250 GB of storage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ScalingConfigManual(
            int? replicas,
            int? shards)
        {
            this.Replicas = replicas;
            this.Shards = shards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ScalingConfigManual" /> class.
        /// </summary>
        public ScalingConfigManual()
        {
        }
    }
}
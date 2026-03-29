
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The current status of factors affecting the read capacity of a serverless index
    /// </summary>
    public sealed partial class ReadCapacityStatus
    {
        /// <summary>
        /// The `state` describes the overall status of factors relating to the read capacity of an index. <br/>
        /// Available values:<br/>
        /// - `Ready` is the state most of the time<br/>
        /// - `Scaling` if the number of replicas or shards has been recently updated by calling the [configure index endpoint](https://docs.pinecone.io/reference/api/2026-04/control-plane/configure_index)<br/>
        /// - `Migrating` if the index is being migrated to a new `node_type`<br/>
        /// - `Error` if there is an error with the read capacity configuration. In that case, see `error_message` for more details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// The number of replicas. Each replica has dedicated  compute resources and data storage. Increasing this number  will increase the total throughput of the index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_replicas")]
        public int? CurrentReplicas { get; set; }

        /// <summary>
        /// The number of shards. Each shard has dedicated storage.  Increasing shards alleiviates index fullness. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_shards")]
        public int? CurrentShards { get; set; }

        /// <summary>
        /// An optional error message indicating any issues with your read capacity configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error_message")]
        public string? ErrorMessage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// The `state` describes the overall status of factors relating to the read capacity of an index. <br/>
        /// Available values:<br/>
        /// - `Ready` is the state most of the time<br/>
        /// - `Scaling` if the number of replicas or shards has been recently updated by calling the [configure index endpoint](https://docs.pinecone.io/reference/api/2026-04/control-plane/configure_index)<br/>
        /// - `Migrating` if the index is being migrated to a new `node_type`<br/>
        /// - `Error` if there is an error with the read capacity configuration. In that case, see `error_message` for more details.
        /// </param>
        /// <param name="currentReplicas">
        /// The number of replicas. Each replica has dedicated  compute resources and data storage. Increasing this number  will increase the total throughput of the index.
        /// </param>
        /// <param name="currentShards">
        /// The number of shards. Each shard has dedicated storage.  Increasing shards alleiviates index fullness. 
        /// </param>
        /// <param name="errorMessage">
        /// An optional error message indicating any issues with your read capacity configuration
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadCapacityStatus(
            string state,
            int? currentReplicas,
            int? currentShards,
            string? errorMessage)
        {
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
            this.CurrentReplicas = currentReplicas;
            this.CurrentShards = currentShards;
            this.ErrorMessage = errorMessage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityStatus" /> class.
        /// </summary>
        public ReadCapacityStatus()
        {
        }
    }
}
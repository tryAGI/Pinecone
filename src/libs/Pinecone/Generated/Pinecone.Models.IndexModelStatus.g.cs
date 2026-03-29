
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The current status of the index<br/>
    /// Example: {"ready":true,"state":"ScalingUpPodSize"}
    /// </summary>
    public sealed partial class IndexModelStatus
    {
        /// <summary>
        /// Whether the index is ready for use
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Ready { get; set; }

        /// <summary>
        /// The state of the index.<br/>
        /// Possible values: `Initializing`, `InitializationFailed`, `ScalingUp`, `ScalingDown`, `ScalingUpPodSize`, `ScalingDownPodSize`, `Terminating`, `Ready`, or `Disabled`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelStatus" /> class.
        /// </summary>
        /// <param name="ready">
        /// Whether the index is ready for use
        /// </param>
        /// <param name="state">
        /// The state of the index.<br/>
        /// Possible values: `Initializing`, `InitializationFailed`, `ScalingUp`, `ScalingDown`, `ScalingUpPodSize`, `ScalingDownPodSize`, `Terminating`, `Ready`, or `Disabled`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexModelStatus(
            bool ready,
            string state)
        {
            this.Ready = ready;
            this.State = state ?? throw new global::System.ArgumentNullException(nameof(state));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelStatus" /> class.
        /// </summary>
        public IndexModelStatus()
        {
        }
    }
}
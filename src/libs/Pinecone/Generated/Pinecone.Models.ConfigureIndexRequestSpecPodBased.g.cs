
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ConfigureIndexRequestSpecPodBased
    {
        /// <summary>
        /// Updated configuration for pod-based indexes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ConfigureIndexRequestSpecPodBasedPod Pod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecPodBased" /> class.
        /// </summary>
        /// <param name="pod">
        /// Updated configuration for pod-based indexes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequestSpecPodBased(
            global::Pinecone.ConfigureIndexRequestSpecPodBasedPod pod)
        {
            this.Pod = pod ?? throw new global::System.ArgumentNullException(nameof(pod));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecPodBased" /> class.
        /// </summary>
        public ConfigureIndexRequestSpecPodBased()
        {
        }
    }
}
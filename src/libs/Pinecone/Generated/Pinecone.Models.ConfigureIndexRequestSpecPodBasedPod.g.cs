
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Updated configuration for pod-based indexes
    /// </summary>
    public sealed partial class ConfigureIndexRequestSpecPodBasedPod
    {
        /// <summary>
        /// The number of replicas. Replicas duplicate your index. They provide higher availability and throughput. Replicas can be scaled up or down as your needs change.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// The type of pod to use. One of `s1`, `p1`, or `p2` appended with `.` and one of `x1`, `x2`, `x4`, or `x8`.<br/>
        /// Default Value: p1.x1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod_type")]
        public string? PodType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecPodBasedPod" /> class.
        /// </summary>
        /// <param name="replicas">
        /// The number of replicas. Replicas duplicate your index. They provide higher availability and throughput. Replicas can be scaled up or down as your needs change.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="podType">
        /// The type of pod to use. One of `s1`, `p1`, or `p2` appended with `.` and one of `x1`, `x2`, `x4`, or `x8`.<br/>
        /// Default Value: p1.x1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequestSpecPodBasedPod(
            int? replicas,
            string? podType)
        {
            this.Replicas = replicas;
            this.PodType = podType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequestSpecPodBasedPod" /> class.
        /// </summary>
        public ConfigureIndexRequestSpecPodBasedPod()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration for dedicated read capacity. See  [this guide](https://docs.pinecone.io/guides/index-data/dedicated-read-nodes) for more details on  how to configure dedicated read capacity.
    /// </summary>
    public sealed partial class ReadCapacityDedicatedConfig
    {
        /// <summary>
        /// The type of machines to use. Available options: `b1` and `t1`. `t1` includes increased processing power and memory.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node_type")]
        public string? NodeType { get; set; }

        /// <summary>
        /// The type of scaling strategy to use.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scaling")]
        public string? Scaling { get; set; }

        /// <summary>
        /// The config to use for manual read capacity scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manual")]
        public global::Pinecone.ScalingConfigManual? Manual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityDedicatedConfig" /> class.
        /// </summary>
        /// <param name="nodeType">
        /// The type of machines to use. Available options: `b1` and `t1`. `t1` includes increased processing power and memory.
        /// </param>
        /// <param name="scaling">
        /// The type of scaling strategy to use.
        /// </param>
        /// <param name="manual">
        /// The config to use for manual read capacity scaling.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadCapacityDedicatedConfig(
            string? nodeType,
            string? scaling,
            global::Pinecone.ScalingConfigManual? manual)
        {
            this.NodeType = nodeType;
            this.Scaling = scaling;
            this.Manual = manual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityDedicatedConfig" /> class.
        /// </summary>
        public ReadCapacityDedicatedConfig()
        {
        }
    }
}
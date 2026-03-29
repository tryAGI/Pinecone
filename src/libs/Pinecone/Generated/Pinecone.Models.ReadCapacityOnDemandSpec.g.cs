
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Example: {"mode":"OnDemand"}
    /// </summary>
    public sealed partial class ReadCapacityOnDemandSpec
    {
        /// <summary>
        /// The mode of the index. Possible values: `OnDemand` or `Dedicated`. Defaults to `OnDemand`. If set to `Dedicated`, `dedicated.node_type`, and `dedicated.scaling` must be specified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityOnDemandSpec" /> class.
        /// </summary>
        /// <param name="mode">
        /// The mode of the index. Possible values: `OnDemand` or `Dedicated`. Defaults to `OnDemand`. If set to `Dedicated`, `dedicated.node_type`, and `dedicated.scaling` must be specified.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadCapacityOnDemandSpec(
            string mode)
        {
            this.Mode = mode ?? throw new global::System.ArgumentNullException(nameof(mode));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityOnDemandSpec" /> class.
        /// </summary>
        public ReadCapacityOnDemandSpec()
        {
        }
    }
}
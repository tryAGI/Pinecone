
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ReadCapacityResponseDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityResponseDiscriminatorModeJsonConverter))]
        public global::Pinecone.ReadCapacityResponseDiscriminatorMode? Mode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityResponseDiscriminator" /> class.
        /// </summary>
        /// <param name="mode"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReadCapacityResponseDiscriminator(
            global::Pinecone.ReadCapacityResponseDiscriminatorMode? mode)
        {
            this.Mode = mode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCapacityResponseDiscriminator" /> class.
        /// </summary>
        public ReadCapacityResponseDiscriminator()
        {
        }
    }
}
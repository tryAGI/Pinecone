
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The list of available models.
    /// </summary>
    public sealed partial class ModelInfoList
    {
        /// <summary>
        /// List of available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Pinecone.ModelInfo>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoList" /> class.
        /// </summary>
        /// <param name="models">
        /// List of available models.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfoList(
            global::System.Collections.Generic.IList<global::Pinecone.ModelInfo>? models)
        {
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoList" /> class.
        /// </summary>
        public ModelInfoList()
        {
        }
    }
}
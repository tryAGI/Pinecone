
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexModelSpecByoc
    {
        /// <summary>
        /// Configuration of a BYOC index.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ByocSpecResponse Byoc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelSpecByoc" /> class.
        /// </summary>
        /// <param name="byoc">
        /// Configuration of a BYOC index.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexModelSpecByoc(
            global::Pinecone.ByocSpecResponse byoc)
        {
            this.Byoc = byoc ?? throw new global::System.ArgumentNullException(nameof(byoc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModelSpecByoc" /> class.
        /// </summary>
        public IndexModelSpecByoc()
        {
        }
    }
}
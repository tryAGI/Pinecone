
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexSpecByoc
    {
        /// <summary>
        /// Configuration needed to deploy an index in a BYOC environment.<br/>
        /// Example: {"environment":"aws-us-east-1-b921"}
        /// </summary>
        /// <example>{"environment":"aws-us-east-1-b921"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoc")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ByocSpec Byoc { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecByoc" /> class.
        /// </summary>
        /// <param name="byoc">
        /// Configuration needed to deploy an index in a BYOC environment.<br/>
        /// Example: {"environment":"aws-us-east-1-b921"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexSpecByoc(
            global::Pinecone.ByocSpec byoc)
        {
            this.Byoc = byoc ?? throw new global::System.ArgumentNullException(nameof(byoc));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecByoc" /> class.
        /// </summary>
        public IndexSpecByoc()
        {
        }
    }
}
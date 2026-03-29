
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EmbedRequestInput
    {
        /// <summary>
        /// The text input to generate embeddings for.<br/>
        /// Example: The quick brown fox jumps over the lazy dog.
        /// </summary>
        /// <example>The quick brown fox jumps over the lazy dog.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRequestInput" /> class.
        /// </summary>
        /// <param name="text">
        /// The text input to generate embeddings for.<br/>
        /// Example: The quick brown fox jumps over the lazy dog.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EmbedRequestInput(
            string? text)
        {
            this.Text = text;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmbedRequestInput" /> class.
        /// </summary>
        public EmbedRequestInput()
        {
        }
    }
}
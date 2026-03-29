
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The configuration needed to create a Pinecone collection.
    /// </summary>
    public sealed partial class CreateCollectionRequest
    {
        /// <summary>
        /// The name of the collection to be created. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The name of the index to be used as the source for the collection.<br/>
        /// Example: example-source-index
        /// </summary>
        /// <example>example-source-index</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the collection to be created. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.
        /// </param>
        /// <param name="source">
        /// The name of the index to be used as the source for the collection.<br/>
        /// Example: example-source-index
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateCollectionRequest(
            string name,
            string source)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCollectionRequest" /> class.
        /// </summary>
        public CreateCollectionRequest()
        {
        }
    }
}
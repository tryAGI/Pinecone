
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration of a BYOC index.
    /// </summary>
    public sealed partial class ByocSpecResponse
    {
        /// <summary>
        /// The environment where the index is hosted.<br/>
        /// Example: aws-us-east-1-b921
        /// </summary>
        /// <example>aws-us-east-1-b921</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Response containing read capacity configuration
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_capacity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ReadCapacityResponse ReadCapacity { get; set; }

        /// <summary>
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </summary>
        /// <example>{"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::Pinecone.MetadataSchema? Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ByocSpecResponse" /> class.
        /// </summary>
        /// <param name="environment">
        /// The environment where the index is hosted.<br/>
        /// Example: aws-us-east-1-b921
        /// </param>
        /// <param name="readCapacity">
        /// Response containing read capacity configuration
        /// </param>
        /// <param name="schema">
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ByocSpecResponse(
            string environment,
            global::Pinecone.ReadCapacityResponse readCapacity,
            global::Pinecone.MetadataSchema? schema)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.ReadCapacity = readCapacity;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByocSpecResponse" /> class.
        /// </summary>
        public ByocSpecResponse()
        {
        }
    }
}
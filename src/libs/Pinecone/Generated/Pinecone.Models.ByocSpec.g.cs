
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration needed to deploy an index in a BYOC environment.<br/>
    /// Example: {"environment":"aws-us-east-1-b921"}
    /// </summary>
    public sealed partial class ByocSpec
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
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_capacity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityJsonConverter))]
        public global::Pinecone.ReadCapacity? ReadCapacity { get; set; }

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
        /// Initializes a new instance of the <see cref="ByocSpec" /> class.
        /// </summary>
        /// <param name="environment">
        /// The environment where the index is hosted.<br/>
        /// Example: aws-us-east-1-b921
        /// </param>
        /// <param name="readCapacity">
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </param>
        /// <param name="schema">
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ByocSpec(
            string environment,
            global::Pinecone.ReadCapacity? readCapacity,
            global::Pinecone.MetadataSchema? schema)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.ReadCapacity = readCapacity;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ByocSpec" /> class.
        /// </summary>
        public ByocSpec()
        {
        }
    }
}
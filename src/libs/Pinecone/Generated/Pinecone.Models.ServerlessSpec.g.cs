
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration needed to deploy a serverless index.
    /// </summary>
    public sealed partial class ServerlessSpec
    {
        /// <summary>
        /// The public cloud where you would like your index hosted.<br/>
        /// Possible values: `gcp`, `aws`, or `azure`.<br/>
        /// Example: aws
        /// </summary>
        /// <example>aws</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cloud { get; set; }

        /// <summary>
        /// The region where you would like your index to be created.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_capacity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityJsonConverter))]
        public global::Pinecone.ReadCapacity? ReadCapacity { get; set; }

        /// <summary>
        /// The name of the collection to be used as the source for the index.<br/>
        /// Example: movie-embeddings
        /// </summary>
        /// <example>movie-embeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_collection")]
        public string? SourceCollection { get; set; }

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
        /// Initializes a new instance of the <see cref="ServerlessSpec" /> class.
        /// </summary>
        /// <param name="cloud">
        /// The public cloud where you would like your index hosted.<br/>
        /// Possible values: `gcp`, `aws`, or `azure`.<br/>
        /// Example: aws
        /// </param>
        /// <param name="region">
        /// The region where you would like your index to be created.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="readCapacity">
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </param>
        /// <param name="sourceCollection">
        /// The name of the collection to be used as the source for the index.<br/>
        /// Example: movie-embeddings
        /// </param>
        /// <param name="schema">
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServerlessSpec(
            string cloud,
            string region,
            global::Pinecone.ReadCapacity? readCapacity,
            string? sourceCollection,
            global::Pinecone.MetadataSchema? schema)
        {
            this.Cloud = cloud ?? throw new global::System.ArgumentNullException(nameof(cloud));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.ReadCapacity = readCapacity;
            this.SourceCollection = sourceCollection;
            this.Schema = schema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServerlessSpec" /> class.
        /// </summary>
        public ServerlessSpec()
        {
        }
    }
}
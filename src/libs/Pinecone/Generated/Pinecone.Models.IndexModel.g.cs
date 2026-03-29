
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The IndexModel describes the configuration and status of a Pinecone index.
    /// </summary>
    public sealed partial class IndexModel
    {
        /// <summary>
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
        /// </summary>
        /// <example>example-index</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Metric { get; set; }

        /// <summary>
        /// The URL address where the index is hosted.<br/>
        /// Example: semantic-search-c01b5b5.svc.us-west1-gcp.pinecone.io
        /// </summary>
        /// <example>semantic-search-c01b5b5.svc.us-west1-gcp.pinecone.io</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("host")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Host { get; set; }

        /// <summary>
        /// The private endpoint URL of an index.<br/>
        /// Example: semantic-search-c01b5b5.svc.private.us-west1-gcp.pinecone.io
        /// </summary>
        /// <example>semantic-search-c01b5b5.svc.private.us-west1-gcp.pinecone.io</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("private_host")]
        public string? PrivateHost { get; set; }

        /// <summary>
        /// Whether [deletion protection](http://docs.pinecone.io/guides/manage-data/manage-indexes#configure-deletion-protection) is enabled/disabled for the index.<br/>
        /// Possible values: `disabled` or `enabled`.<br/>
        /// Default Value: disabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deletion_protection")]
        public string? DeletionProtection { get; set; }

        /// <summary>
        /// Custom user tags added to an index. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'.  Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string.<br/>
        /// Example: {"tag0":"val0","tag1":"val1"}
        /// </summary>
        /// <example>{"tag0":"val0","tag1":"val1"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// The embedding model and document fields mapped to embedding inputs.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </summary>
        /// <example>{"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        public global::Pinecone.ModelIndexEmbed? Embed { get; set; }

        /// <summary>
        /// The spec object defines how the index should be deployed.<br/>
        /// Example: {"pod":{"environment":"us-east-1-aws","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1}}
        /// </summary>
        /// <example>{"pod":{"environment":"us-east-1-aws","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.OneOfJsonConverter<global::Pinecone.IndexModelSpecServerless, global::Pinecone.IndexModelSpecPodBased, global::Pinecone.IndexModelSpecByoc>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.OneOf<global::Pinecone.IndexModelSpecServerless, global::Pinecone.IndexModelSpecPodBased, global::Pinecone.IndexModelSpecByoc> Spec { get; set; }

        /// <summary>
        /// The current status of the index<br/>
        /// Example: {"ready":true,"state":"ScalingUpPodSize"}
        /// </summary>
        /// <example>{"ready":true,"state":"ScalingUpPodSize"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.IndexModelStatus Status { get; set; }

        /// <summary>
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </summary>
        /// <default>"dense"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VectorType { get; set; } = "dense";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </param>
        /// <param name="host">
        /// The URL address where the index is hosted.<br/>
        /// Example: semantic-search-c01b5b5.svc.us-west1-gcp.pinecone.io
        /// </param>
        /// <param name="spec">
        /// The spec object defines how the index should be deployed.<br/>
        /// Example: {"pod":{"environment":"us-east-1-aws","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1}}
        /// </param>
        /// <param name="status">
        /// The current status of the index<br/>
        /// Example: {"ready":true,"state":"ScalingUpPodSize"}
        /// </param>
        /// <param name="vectorType">
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </param>
        /// <param name="dimension">
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="privateHost">
        /// The private endpoint URL of an index.<br/>
        /// Example: semantic-search-c01b5b5.svc.private.us-west1-gcp.pinecone.io
        /// </param>
        /// <param name="deletionProtection">
        /// Whether [deletion protection](http://docs.pinecone.io/guides/manage-data/manage-indexes#configure-deletion-protection) is enabled/disabled for the index.<br/>
        /// Possible values: `disabled` or `enabled`.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="tags">
        /// Custom user tags added to an index. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'.  Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string.<br/>
        /// Example: {"tag0":"val0","tag1":"val1"}
        /// </param>
        /// <param name="embed">
        /// The embedding model and document fields mapped to embedding inputs.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexModel(
            string name,
            string metric,
            string host,
            global::Pinecone.OneOf<global::Pinecone.IndexModelSpecServerless, global::Pinecone.IndexModelSpecPodBased, global::Pinecone.IndexModelSpecByoc> spec,
            global::Pinecone.IndexModelStatus status,
            string vectorType,
            int? dimension,
            string? privateHost,
            string? deletionProtection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::Pinecone.ModelIndexEmbed? embed)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dimension = dimension;
            this.Metric = metric ?? throw new global::System.ArgumentNullException(nameof(metric));
            this.Host = host ?? throw new global::System.ArgumentNullException(nameof(host));
            this.PrivateHost = privateHost;
            this.DeletionProtection = deletionProtection;
            this.Tags = tags;
            this.Embed = embed;
            this.Spec = spec;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.VectorType = vectorType ?? throw new global::System.ArgumentNullException(nameof(vectorType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel" /> class.
        /// </summary>
        public IndexModel()
        {
        }
    }
}
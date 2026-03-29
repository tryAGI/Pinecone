
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The configuration needed to create a Pinecone index.
    /// </summary>
    public sealed partial class CreateIndexRequest
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
        public string? Metric { get; set; }

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
        /// The spec object defines how the index should be deployed.<br/>
        /// For serverless indexes, you define only the [cloud and region](http://docs.pinecone.io/guides/index-data/create-an-index#cloud-regions) where the index should be hosted. For pod-based indexes, you define the [environment](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-environments) where the index should be hosted, the [pod type and size](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-types) to use, and other index characteristics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.IndexSpecJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.IndexSpec Spec { get; set; }

        /// <summary>
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_type")]
        public string? VectorType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
        /// </param>
        /// <param name="spec">
        /// The spec object defines how the index should be deployed.<br/>
        /// For serverless indexes, you define only the [cloud and region](http://docs.pinecone.io/guides/index-data/create-an-index#cloud-regions) where the index should be hosted. For pod-based indexes, you define the [environment](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-environments) where the index should be hosted, the [pod type and size](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-types) to use, and other index characteristics.
        /// </param>
        /// <param name="dimension">
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
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
        /// <param name="vectorType">
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIndexRequest(
            string name,
            global::Pinecone.IndexSpec spec,
            int? dimension,
            string? metric,
            string? deletionProtection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            string? vectorType)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Dimension = dimension;
            this.Metric = metric;
            this.DeletionProtection = deletionProtection;
            this.Tags = tags;
            this.Spec = spec;
            this.VectorType = vectorType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexRequest" /> class.
        /// </summary>
        public CreateIndexRequest()
        {
        }
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration needed to deploy a pod-based index.<br/>
    /// Example: {"environment":"us-east1-gcp","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1,"source_collection":"movie-embeddings"}
    /// </summary>
    public sealed partial class PodSpec
    {
        /// <summary>
        /// The environment where the index is hosted.<br/>
        /// Example: us-east1-gcp
        /// </summary>
        /// <example>us-east1-gcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// The number of replicas. Replicas duplicate your index. They provide higher availability and throughput. Replicas can be scaled up or down as your needs change.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public int? Replicas { get; set; }

        /// <summary>
        /// The number of shards. Shards split your data across multiple pods so you can fit more data into an index.<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public int? Shards { get; set; }

        /// <summary>
        /// The type of pod to use. One of `s1`, `p1`, or `p2` appended with `.` and one of `x1`, `x2`, `x4`, or `x8`.<br/>
        /// Default Value: p1.x1
        /// </summary>
        /// <default>"p1.x1"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PodType { get; set; } = "p1.x1";

        /// <summary>
        /// The number of pods to be used in the index. This should be equal to `shards` x `replicas`.'<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pods")]
        public int? Pods { get; set; }

        /// <summary>
        /// Configuration for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `metadata_config` is present, only specified metadata fields are indexed. These configurations are only valid for use with pod-based indexes.<br/>
        /// Example: {"indexed":["genre","title","imdb_rating"]}
        /// </summary>
        /// <example>{"indexed":["genre","title","imdb_rating"]}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_config")]
        public global::Pinecone.PodSpecMetadataConfig? MetadataConfig { get; set; }

        /// <summary>
        /// The name of the collection to be used as the source for the index.<br/>
        /// Example: movie-embeddings
        /// </summary>
        /// <example>movie-embeddings</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_collection")]
        public string? SourceCollection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PodSpec" /> class.
        /// </summary>
        /// <param name="environment">
        /// The environment where the index is hosted.<br/>
        /// Example: us-east1-gcp
        /// </param>
        /// <param name="podType">
        /// The type of pod to use. One of `s1`, `p1`, or `p2` appended with `.` and one of `x1`, `x2`, `x4`, or `x8`.<br/>
        /// Default Value: p1.x1
        /// </param>
        /// <param name="replicas">
        /// The number of replicas. Replicas duplicate your index. They provide higher availability and throughput. Replicas can be scaled up or down as your needs change.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="shards">
        /// The number of shards. Shards split your data across multiple pods so you can fit more data into an index.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="pods">
        /// The number of pods to be used in the index. This should be equal to `shards` x `replicas`.'<br/>
        /// Default Value: 1<br/>
        /// Example: 1
        /// </param>
        /// <param name="metadataConfig">
        /// Configuration for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `metadata_config` is present, only specified metadata fields are indexed. These configurations are only valid for use with pod-based indexes.<br/>
        /// Example: {"indexed":["genre","title","imdb_rating"]}
        /// </param>
        /// <param name="sourceCollection">
        /// The name of the collection to be used as the source for the index.<br/>
        /// Example: movie-embeddings
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PodSpec(
            string environment,
            string podType,
            int? replicas,
            int? shards,
            int? pods,
            global::Pinecone.PodSpecMetadataConfig? metadataConfig,
            string? sourceCollection)
        {
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
            this.Replicas = replicas;
            this.Shards = shards;
            this.PodType = podType ?? throw new global::System.ArgumentNullException(nameof(podType));
            this.Pods = pods;
            this.MetadataConfig = metadataConfig;
            this.SourceCollection = sourceCollection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PodSpec" /> class.
        /// </summary>
        public PodSpec()
        {
        }
    }
}
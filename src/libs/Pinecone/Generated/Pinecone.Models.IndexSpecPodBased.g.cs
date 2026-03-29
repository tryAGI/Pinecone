
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class IndexSpecPodBased
    {
        /// <summary>
        /// Configuration needed to deploy a pod-based index.<br/>
        /// Example: {"environment":"us-east1-gcp","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1,"source_collection":"movie-embeddings"}
        /// </summary>
        /// <example>{"environment":"us-east1-gcp","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1,"source_collection":"movie-embeddings"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pod")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.PodSpec Pod { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecPodBased" /> class.
        /// </summary>
        /// <param name="pod">
        /// Configuration needed to deploy a pod-based index.<br/>
        /// Example: {"environment":"us-east1-gcp","metadata_config":{"indexed":["genre","title","imdb_rating"]},"pod_type":"p1.x1","pods":1,"replicas":1,"shards":1,"source_collection":"movie-embeddings"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexSpecPodBased(
            global::Pinecone.PodSpec pod)
        {
            this.Pod = pod ?? throw new global::System.ArgumentNullException(nameof(pod));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexSpecPodBased" /> class.
        /// </summary>
        public IndexSpecPodBased()
        {
        }
    }
}
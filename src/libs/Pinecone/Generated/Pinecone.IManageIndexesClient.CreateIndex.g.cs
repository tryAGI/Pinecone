#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Create an index<br/>
        /// Create a Pinecone index. This is where you specify the measure of similarity, the dimension of vectors to be stored in the index, which cloud provider you would like to deploy with, and more.<br/>
        ///   <br/>
        /// For guidance and examples, see [Create an index](https://docs.pinecone.io/guides/index-data/create-an-index).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> CreateIndexAsync(

            global::Pinecone.CreateIndexRequest request,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an index<br/>
        /// Create a Pinecone index. This is where you specify the measure of similarity, the dimension of vectors to be stored in the index, which cloud provider you would like to deploy with, and more.<br/>
        ///   <br/>
        /// For guidance and examples, see [Create an index](https://docs.pinecone.io/guides/index-data/create-an-index).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="name">
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
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
        /// <param name="spec">
        /// The spec object defines how the index should be deployed.<br/>
        /// For serverless indexes, you define only the [cloud and region](http://docs.pinecone.io/guides/index-data/create-an-index#cloud-regions) where the index should be hosted. For pod-based indexes, you define the [environment](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-environments) where the index should be hosted, the [pod type and size](http://docs.pinecone.io/guides/indexes/pods/understanding-pod-based-indexes#pod-types) to use, and other index characteristics.
        /// </param>
        /// <param name="vectorType">
        /// The index vector type. You can use 'dense' or 'sparse'. If 'dense', the vector dimension must be specified.  If 'sparse', the vector dimension should not be specified.<br/>
        /// Default Value: dense
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> CreateIndexAsync(
            string name,
            global::Pinecone.IndexSpec spec,
            string xPineconeApiVersion = "2026-04",
            int? dimension = default,
            string? metric = default,
            string? deletionProtection = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? vectorType = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
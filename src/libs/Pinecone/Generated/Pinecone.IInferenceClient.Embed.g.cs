#nullable enable

namespace Pinecone
{
    public partial interface IInferenceClient
    {
        /// <summary>
        /// Generate vectors<br/>
        /// Generate vector embeddings for input data. This endpoint uses Pinecone's [hosted embedding models](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.EmbeddingsList> EmbedAsync(

            global::Pinecone.EmbedRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate vectors<br/>
        /// Generate vector embeddings for input data. This endpoint uses Pinecone's [hosted embedding models](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="model">
        /// The [model](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) to use for embedding generation.<br/>
        /// Example: multilingual-e5-large
        /// </param>
        /// <param name="parameters">
        /// Additional model-specific parameters. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available model parameters.<br/>
        /// Example: {"input_type":"passage","truncate":"END"}
        /// </param>
        /// <param name="inputs">
        /// List of inputs to generate embeddings for.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.EmbeddingsList> EmbedAsync(
            string model,
            global::System.Collections.Generic.IList<global::Pinecone.EmbedRequestInput> inputs,
            string xPineconeApiVersion = "2026-04",
            object? parameters = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
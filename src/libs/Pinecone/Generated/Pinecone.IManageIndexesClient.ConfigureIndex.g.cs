#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Configure an index<br/>
        /// Configure an existing index. For guidance and examples, see [Manage indexes](https://docs.pinecone.io/guides/manage-data/manage-indexes).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> ConfigureIndexAsync(
            string indexName,

            global::Pinecone.ConfigureIndexRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Configure an index<br/>
        /// Configure an existing index. For guidance and examples, see [Manage indexes](https://docs.pinecone.io/guides/manage-data/manage-indexes).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="indexName"></param>
        /// <param name="spec">
        /// The spec object defines how the index should be deployed.  Only some attributes of an index's spec may be updated.  In general, you can modify settings related to scaling and  configuration but you cannot change the cloud or region  where the index is hosted.
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
        /// Configure the integrated inference embedding settings for this index.<br/>
        /// You can convert an existing index to an integrated index by specifying the embedding model and field_map. The index vector type and dimension must match the model vector type and dimension, and the index similarity metric must be supported by the model. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
        /// You can later change the embedding configuration to update the field map, read parameters, or write parameters. Once set, the model cannot be changed.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> ConfigureIndexAsync(
            string indexName,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.OneOf<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>? spec = default,
            string? deletionProtection = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Pinecone.ConfigureIndexRequestEmbed? embed = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Create an index with integrated embedding<br/>
        /// Create an index with integrated embedding.<br/>
        /// With this type of index, you provide source text, and  Pinecone uses a [hosted embedding model](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models)  to convert the text automatically during [upsert](https://docs.pinecone.io/reference/api/2026-04/data-plane/upsert_records)  and [search](https://docs.pinecone.io/reference/api/2026-04/data-plane/search_records).  <br/>
        /// For guidance and examples, see [Create an index](https://docs.pinecone.io/guides/index-data/create-an-index#integrated-embedding).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> CreateIndexForModelAsync(

            global::Pinecone.CreateIndexForModelRequest request,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an index with integrated embedding<br/>
        /// Create an index with integrated embedding.<br/>
        /// With this type of index, you provide source text, and  Pinecone uses a [hosted embedding model](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models)  to convert the text automatically during [upsert](https://docs.pinecone.io/reference/api/2026-04/data-plane/upsert_records)  and [search](https://docs.pinecone.io/reference/api/2026-04/data-plane/search_records).  <br/>
        /// For guidance and examples, see [Create an index](https://docs.pinecone.io/guides/index-data/create-an-index#integrated-embedding).
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="name">
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
        /// </param>
        /// <param name="cloud">
        /// The public cloud where you would like your index hosted.<br/>
        /// Possible values: `gcp`, `aws`, or `azure`.<br/>
        /// Example: aws
        /// </param>
        /// <param name="region">
        /// The region where you would like your index to be created.<br/>
        /// Example: us-east-1
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
        /// <param name="schema">
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </param>
        /// <param name="readCapacity">
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </param>
        /// <param name="embed">
        /// Specify the integrated inference embedding configuration for the index.<br/>
        /// Once set the model cannot be changed, but you can later update the embedding configuration for an integrated inference index including field map, read parameters, or write parameters.<br/>
        /// Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.IndexModel> CreateIndexForModelAsync(
            string name,
            string cloud,
            string region,
            global::Pinecone.CreateIndexForModelRequestEmbed embed,
            string xPineconeApiVersion = "2026-04",
            string? deletionProtection = default,
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            global::Pinecone.MetadataSchema? schema = default,
            global::Pinecone.ReadCapacity? readCapacity = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
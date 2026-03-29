
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The desired configuration for the index and associated embedding model.
    /// </summary>
    public sealed partial class CreateIndexForModelRequest
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
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </summary>
        /// <example>{"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::Pinecone.MetadataSchema? Schema { get; set; }

        /// <summary>
        /// By default the index will be created with read capacity  mode `OnDemand`. If you prefer to allocate dedicated read  nodes for your workload, you must specify mode `Dedicated` and additional configurations for `node_type` and `scaling`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("read_capacity")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.ReadCapacityJsonConverter))]
        public global::Pinecone.ReadCapacity? ReadCapacity { get; set; }

        /// <summary>
        /// Specify the integrated inference embedding configuration for the index.<br/>
        /// Once set the model cannot be changed, but you can later update the embedding configuration for an integrated inference index including field map, read parameters, or write parameters.<br/>
        /// Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </summary>
        /// <example>{"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.CreateIndexForModelRequestEmbed Embed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexForModelRequest" /> class.
        /// </summary>
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
        /// <param name="embed">
        /// Specify the integrated inference embedding configuration for the index.<br/>
        /// Once set the model cannot be changed, but you can later update the embedding configuration for an integrated inference index including field map, read parameters, or write parameters.<br/>
        /// Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"metric":"cosine","model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateIndexForModelRequest(
            string name,
            string cloud,
            string region,
            global::Pinecone.CreateIndexForModelRequestEmbed embed,
            string? deletionProtection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::Pinecone.MetadataSchema? schema,
            global::Pinecone.ReadCapacity? readCapacity)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Cloud = cloud ?? throw new global::System.ArgumentNullException(nameof(cloud));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.DeletionProtection = deletionProtection;
            this.Tags = tags;
            this.Schema = schema;
            this.ReadCapacity = readCapacity;
            this.Embed = embed ?? throw new global::System.ArgumentNullException(nameof(embed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateIndexForModelRequest" /> class.
        /// </summary>
        public CreateIndexForModelRequest()
        {
        }
    }
}
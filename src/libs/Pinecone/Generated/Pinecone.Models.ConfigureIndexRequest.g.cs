
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Configuration used to scale an index.
    /// </summary>
    public sealed partial class ConfigureIndexRequest
    {
        /// <summary>
        /// The spec object defines how the index should be deployed.  Only some attributes of an index's spec may be updated.  In general, you can modify settings related to scaling and  configuration but you cannot change the cloud or region  where the index is hosted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spec")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.OneOfJsonConverter<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>))]
        public global::Pinecone.OneOf<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>? Spec { get; set; }

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
        /// Configure the integrated inference embedding settings for this index.<br/>
        /// You can convert an existing index to an integrated index by specifying the embedding model and field_map. The index vector type and dimension must match the model vector type and dimension, and the index similarity metric must be supported by the model. Refer to the [model guide](https://docs.pinecone.io/guides/index-data/create-an-index#embedding-models) for available models and model details.<br/>
        /// You can later change the embedding configuration to update the field map, read parameters, or write parameters. Once set, the model cannot be changed.<br/>
        /// Example: {"field_map":{"text":"your-text-field"},"model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}
        /// </summary>
        /// <example>{"field_map":{"text":"your-text-field"},"model":"multilingual-e5-large","read_parameters":{"input_type":"query","truncate":"NONE"},"write_parameters":{"input_type":"passage"}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("embed")]
        public global::Pinecone.ConfigureIndexRequestEmbed? Embed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequest" /> class.
        /// </summary>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConfigureIndexRequest(
            global::Pinecone.OneOf<global::Pinecone.ConfigureIndexRequestSpecServerless, global::Pinecone.ConfigureIndexRequestSpecPodBased, global::Pinecone.ConfigureIndexRequestSpecByoc>? spec,
            string? deletionProtection,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            global::Pinecone.ConfigureIndexRequestEmbed? embed)
        {
            this.Spec = spec;
            this.DeletionProtection = deletionProtection;
            this.Tags = tags;
            this.Embed = embed;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigureIndexRequest" /> class.
        /// </summary>
        public ConfigureIndexRequest()
        {
        }
    }
}
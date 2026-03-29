
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MetadataSchemaFields2
    {
        /// <summary>
        /// Whether the field is filterable. If true, the field is indexed and can be used in filters. Only true values are allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filterable")]
        public bool? Filterable { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchemaFields2" /> class.
        /// </summary>
        /// <param name="filterable">
        /// Whether the field is filterable. If true, the field is indexed and can be used in filters. Only true values are allowed.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MetadataSchemaFields2(
            bool? filterable)
        {
            this.Filterable = filterable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetadataSchemaFields2" /> class.
        /// </summary>
        public MetadataSchemaFields2()
        {
        }
    }
}
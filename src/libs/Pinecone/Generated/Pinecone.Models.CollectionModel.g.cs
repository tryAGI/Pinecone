
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The CollectionModel describes the configuration and status of a Pinecone collection.
    /// </summary>
    public sealed partial class CollectionModel
    {
        /// <summary>
        /// The name of the collection.<br/>
        /// Example: example-collection
        /// </summary>
        /// <example>example-collection</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The size of the collection in bytes.<br/>
        /// Example: 10000000
        /// </summary>
        /// <example>10000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size")]
        public long? Size { get; set; }

        /// <summary>
        /// The status of the collection.<br/>
        /// Possible values: `Initializing`, `Ready`, or `Terminating`.<br/>
        /// Example: Initializing
        /// </summary>
        /// <example>Initializing</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// The dimension of the vectors stored in each record held in the collection.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// The number of records stored in the collection.<br/>
        /// Example: 120000
        /// </summary>
        /// <example>120000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector_count")]
        public int? VectorCount { get; set; }

        /// <summary>
        /// The environment where the collection is hosted.<br/>
        /// Example: us-east1-gcp
        /// </summary>
        /// <example>us-east1-gcp</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Environment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionModel" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the collection.<br/>
        /// Example: example-collection
        /// </param>
        /// <param name="status">
        /// The status of the collection.<br/>
        /// Possible values: `Initializing`, `Ready`, or `Terminating`.<br/>
        /// Example: Initializing
        /// </param>
        /// <param name="environment">
        /// The environment where the collection is hosted.<br/>
        /// Example: us-east1-gcp
        /// </param>
        /// <param name="size">
        /// The size of the collection in bytes.<br/>
        /// Example: 10000000
        /// </param>
        /// <param name="dimension">
        /// The dimension of the vectors stored in each record held in the collection.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="vectorCount">
        /// The number of records stored in the collection.<br/>
        /// Example: 120000
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CollectionModel(
            string name,
            string status,
            string environment,
            long? size,
            int? dimension,
            int? vectorCount)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Size = size;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Dimension = dimension;
            this.VectorCount = vectorCount;
            this.Environment = environment ?? throw new global::System.ArgumentNullException(nameof(environment));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CollectionModel" /> class.
        /// </summary>
        public CollectionModel()
        {
        }
    }
}
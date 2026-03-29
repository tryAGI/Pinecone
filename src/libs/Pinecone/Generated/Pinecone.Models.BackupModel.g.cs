
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The BackupModel describes the configuration and status of a Pinecone backup.
    /// </summary>
    public sealed partial class BackupModel
    {
        /// <summary>
        /// Unique identifier for the backup.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440001
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("backup_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BackupId { get; set; }

        /// <summary>
        /// Name of the index from which the backup was taken.<br/>
        /// Example: my-index
        /// </summary>
        /// <example>my-index</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_index_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceIndexName { get; set; }

        /// <summary>
        /// ID of the index.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </summary>
        /// <example>670e8400-e29b-41d4-a716-446655440000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_index_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceIndexId { get; set; }

        /// <summary>
        /// Optional user-defined name for the backup.<br/>
        /// Example: backup-2025-02-04
        /// </summary>
        /// <example>backup-2025-02-04</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Optional description providing context for the backup.<br/>
        /// Example: Backup before bulk update.
        /// </summary>
        /// <example>Backup before bulk update.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Current status of the backup (e.g., Initializing, Ready, Failed).<br/>
        /// Example: Ready
        /// </summary>
        /// <example>Ready</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Status { get; set; }

        /// <summary>
        /// Cloud provider where the backup is stored.<br/>
        /// Example: aws
        /// </summary>
        /// <example>aws</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cloud")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cloud { get; set; }

        /// <summary>
        /// Cloud region where the backup is stored.<br/>
        /// Example: us-east-1
        /// </summary>
        /// <example>us-east-1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Region { get; set; }

        /// <summary>
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </summary>
        /// <example>1536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("dimension")]
        public int? Dimension { get; set; }

        /// <summary>
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metric")]
        public string? Metric { get; set; }

        /// <summary>
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </summary>
        /// <example>{"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        public global::Pinecone.MetadataSchema? Schema { get; set; }

        /// <summary>
        /// Total number of records in the backup.<br/>
        /// Example: 120000
        /// </summary>
        /// <example>120000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("record_count")]
        public int? RecordCount { get; set; }

        /// <summary>
        /// Number of namespaces in the backup.<br/>
        /// Example: 3
        /// </summary>
        /// <example>3</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace_count")]
        public int? NamespaceCount { get; set; }

        /// <summary>
        /// Size of the backup in bytes.<br/>
        /// Example: 10000000
        /// </summary>
        /// <example>10000000</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        public long? SizeBytes { get; set; }

        /// <summary>
        /// Custom user tags added to an index. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'.  Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string.<br/>
        /// Example: {"tag0":"val0","tag1":"val1"}
        /// </summary>
        /// <example>{"tag0":"val0","tag1":"val1"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("tags")]
        public global::System.Collections.Generic.Dictionary<string, string>? Tags { get; set; }

        /// <summary>
        /// Timestamp when the backup was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModel" /> class.
        /// </summary>
        /// <param name="backupId">
        /// Unique identifier for the backup.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440001
        /// </param>
        /// <param name="sourceIndexName">
        /// Name of the index from which the backup was taken.<br/>
        /// Example: my-index
        /// </param>
        /// <param name="sourceIndexId">
        /// ID of the index.<br/>
        /// Example: 670e8400-e29b-41d4-a716-446655440000
        /// </param>
        /// <param name="status">
        /// Current status of the backup (e.g., Initializing, Ready, Failed).<br/>
        /// Example: Ready
        /// </param>
        /// <param name="cloud">
        /// Cloud provider where the backup is stored.<br/>
        /// Example: aws
        /// </param>
        /// <param name="region">
        /// Cloud region where the backup is stored.<br/>
        /// Example: us-east-1
        /// </param>
        /// <param name="name">
        /// Optional user-defined name for the backup.<br/>
        /// Example: backup-2025-02-04
        /// </param>
        /// <param name="description">
        /// Optional description providing context for the backup.<br/>
        /// Example: Backup before bulk update.
        /// </param>
        /// <param name="dimension">
        /// The dimensions of the vectors to be inserted in the index.<br/>
        /// Example: 1536
        /// </param>
        /// <param name="metric">
        /// The distance metric to be used for similarity search. You can use 'euclidean', 'cosine', or 'dotproduct'. If the 'vector_type' is 'sparse', the metric must be 'dotproduct'. If the `vector_type` is `dense`, the metric defaults to 'cosine'.<br/>
        /// Possible values: `cosine`, `euclidean`, or `dotproduct`.
        /// </param>
        /// <param name="schema">
        /// Schema for the behavior of Pinecone's internal metadata index. By default, all metadata is indexed; when `schema` is present, only fields which are present in the `fields` object with a `filterable: true` are indexed. Note that `filterable: false` is not currently supported.<br/>
        /// Example: {"fields":{"description":{"filterable":true},"genre":{"filterable":true},"year":{"filterable":true}}}
        /// </param>
        /// <param name="recordCount">
        /// Total number of records in the backup.<br/>
        /// Example: 120000
        /// </param>
        /// <param name="namespaceCount">
        /// Number of namespaces in the backup.<br/>
        /// Example: 3
        /// </param>
        /// <param name="sizeBytes">
        /// Size of the backup in bytes.<br/>
        /// Example: 10000000
        /// </param>
        /// <param name="tags">
        /// Custom user tags added to an index. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'.  Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string.<br/>
        /// Example: {"tag0":"val0","tag1":"val1"}
        /// </param>
        /// <param name="createdAt">
        /// Timestamp when the backup was created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BackupModel(
            string backupId,
            string sourceIndexName,
            string sourceIndexId,
            string status,
            string cloud,
            string region,
            string? name,
            string? description,
            int? dimension,
            string? metric,
            global::Pinecone.MetadataSchema? schema,
            int? recordCount,
            int? namespaceCount,
            long? sizeBytes,
            global::System.Collections.Generic.Dictionary<string, string>? tags,
            string? createdAt)
        {
            this.BackupId = backupId ?? throw new global::System.ArgumentNullException(nameof(backupId));
            this.SourceIndexName = sourceIndexName ?? throw new global::System.ArgumentNullException(nameof(sourceIndexName));
            this.SourceIndexId = sourceIndexId ?? throw new global::System.ArgumentNullException(nameof(sourceIndexId));
            this.Name = name;
            this.Description = description;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.Cloud = cloud ?? throw new global::System.ArgumentNullException(nameof(cloud));
            this.Region = region ?? throw new global::System.ArgumentNullException(nameof(region));
            this.Dimension = dimension;
            this.Metric = metric;
            this.Schema = schema;
            this.RecordCount = recordCount;
            this.NamespaceCount = namespaceCount;
            this.SizeBytes = sizeBytes;
            this.Tags = tags;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BackupModel" /> class.
        /// </summary>
        public BackupModel()
        {
        }
    }
}
#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Create an index from a backup<br/>
        /// Create an index from a backup.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="backupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.CreateIndexFromBackupResponse> CreateIndexFromBackupOperationAsync(
            string backupId,

            global::Pinecone.CreateIndexFromBackupRequest request,
            string xPineconeApiVersion = "2026-04",
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create an index from a backup<br/>
        /// Create an index from a backup.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="backupId"></param>
        /// <param name="name">
        /// The name of the index. Resource name must be 1-45 characters long, start and end with an alphanumeric character, and consist only of lower case alphanumeric characters or '-'.<br/>
        /// Example: example-index
        /// </param>
        /// <param name="tags">
        /// Custom user tags added to an index. Keys must be 80 characters or less. Values must be 120 characters or less. Keys must be alphanumeric, '_', or '-'.  Values must be alphanumeric, ';', '@', '_', '-', '.', '+', or ' '. To unset a key, set the value to be an empty string.<br/>
        /// Example: {"tag0":"val0","tag1":"val1"}
        /// </param>
        /// <param name="deletionProtection">
        /// Whether [deletion protection](http://docs.pinecone.io/guides/manage-data/manage-indexes#configure-deletion-protection) is enabled/disabled for the index.<br/>
        /// Possible values: `disabled` or `enabled`.<br/>
        /// Default Value: disabled
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.CreateIndexFromBackupResponse> CreateIndexFromBackupOperationAsync(
            string backupId,
            string name,
            string xPineconeApiVersion = "2026-04",
            global::System.Collections.Generic.Dictionary<string, string>? tags = default,
            string? deletionProtection = default,
            global::Pinecone.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
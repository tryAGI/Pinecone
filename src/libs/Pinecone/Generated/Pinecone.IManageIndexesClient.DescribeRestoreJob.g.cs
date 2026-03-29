#nullable enable

namespace Pinecone
{
    public partial interface IManageIndexesClient
    {
        /// <summary>
        /// Describe a restore job<br/>
        /// Get a description of a restore job.
        /// </summary>
        /// <param name="xPineconeApiVersion">
        /// Default Value: 2026-04
        /// </param>
        /// <param name="jobId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Pinecone.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Pinecone.RestoreJobModel> DescribeRestoreJobAsync(
            string jobId,
            string xPineconeApiVersion = "2026-04",
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}

#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The response shape used for all error responses.<br/>
    /// Example: {"error":{"code":"QUOTA_EXCEEDED","message":"The index exceeds the project quota of 5 pods by 2 pods. Upgrade your account or change the project settings to increase the quota."},"status":429}
    /// </summary>
    public sealed partial class ErrorResponse
    {
        /// <summary>
        /// The HTTP status code of the error.<br/>
        /// Example: 500
        /// </summary>
        /// <example>500</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Status { get; set; }

        /// <summary>
        /// Detailed information about the error that occurred.<br/>
        /// Example: {"code":"INVALID_ARGUMENT","message":"Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen."}
        /// </summary>
        /// <example>{"code":"INVALID_ARGUMENT","message":"Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen."}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Pinecone.ErrorResponseError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        /// <param name="status">
        /// The HTTP status code of the error.<br/>
        /// Example: 500
        /// </param>
        /// <param name="error">
        /// Detailed information about the error that occurred.<br/>
        /// Example: {"code":"INVALID_ARGUMENT","message":"Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen."}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponse(
            int status,
            global::Pinecone.ErrorResponseError error)
        {
            this.Status = status;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponse" /> class.
        /// </summary>
        public ErrorResponse()
        {
        }
    }
}
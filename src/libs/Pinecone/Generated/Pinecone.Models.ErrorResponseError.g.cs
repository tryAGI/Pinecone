
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Detailed information about the error that occurred.<br/>
    /// Example: {"code":"INVALID_ARGUMENT","message":"Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen."}
    /// </summary>
    public sealed partial class ErrorResponseError
    {
        /// <summary>
        /// The error code.<br/>
        /// Possible values: `OK`, `UNKNOWN`, `INVALID_ARGUMENT`, `DEADLINE_EXCEEDED`, `QUOTA_EXCEEDED`, `NOT_FOUND`, `ALREADY_EXISTS`, `PERMISSION_DENIED`, `UNAUTHENTICATED`, `RESOURCE_EXHAUSTED`, `FAILED_PRECONDITION`, `ABORTED`, `OUT_OF_RANGE`, `UNIMPLEMENTED`, `INTERNAL`, `UNAVAILABLE`, `DATA_LOSS`, `FORBIDDEN`, `UNPROCESSABLE_ENTITY`, or `PAYMENT_REQUIRED`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable description of the error<br/>
        /// Example: Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen.
        /// </summary>
        /// <example>Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional information about the error. This field is not guaranteed to be present.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("details")]
        public object? Details { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        /// <param name="code">
        /// The error code.<br/>
        /// Possible values: `OK`, `UNKNOWN`, `INVALID_ARGUMENT`, `DEADLINE_EXCEEDED`, `QUOTA_EXCEEDED`, `NOT_FOUND`, `ALREADY_EXISTS`, `PERMISSION_DENIED`, `UNAUTHENTICATED`, `RESOURCE_EXHAUSTED`, `FAILED_PRECONDITION`, `ABORTED`, `OUT_OF_RANGE`, `UNIMPLEMENTED`, `INTERNAL`, `UNAVAILABLE`, `DATA_LOSS`, `FORBIDDEN`, `UNPROCESSABLE_ENTITY`, or `PAYMENT_REQUIRED`.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error<br/>
        /// Example: Index name must contain only lowercase alphanumeric characters or hyphens, and must not begin or end with a hyphen.
        /// </param>
        /// <param name="details">
        /// Additional information about the error. This field is not guaranteed to be present.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorResponseError(
            string code,
            string message,
            object? details)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Details = details;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorResponseError" /> class.
        /// </summary>
        public ErrorResponseError()
        {
        }
    }
}
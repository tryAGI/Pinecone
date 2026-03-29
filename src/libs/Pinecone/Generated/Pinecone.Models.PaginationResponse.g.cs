
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// The pagination object that is returned with paginated responses.<br/>
    /// Example: {"next":"dXNlcl9pZD11c2VyXzE="}
    /// </summary>
    public sealed partial class PaginationResponse
    {
        /// <summary>
        /// The token to use to retrieve the next page of results.<br/>
        /// Example: dXNlcl9pZD11c2VyXzE=
        /// </summary>
        /// <example>dXNlcl9pZD11c2VyXzE=</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        /// <param name="next">
        /// The token to use to retrieve the next page of results.<br/>
        /// Example: dXNlcl9pZD11c2VyXzE=
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationResponse(
            string next)
        {
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponse" /> class.
        /// </summary>
        public PaginationResponse()
        {
        }
    }
}
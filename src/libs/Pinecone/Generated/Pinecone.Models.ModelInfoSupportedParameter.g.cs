
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// Describes a parameter supported by the model, including parameter value constraints.
    /// </summary>
    public sealed partial class ModelInfoSupportedParameter
    {
        /// <summary>
        /// The name of the parameter.<br/>
        /// Example: input_type
        /// </summary>
        /// <example>input_type</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameter")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Parameter { get; set; }

        /// <summary>
        /// The parameter type e.g. 'one_of', 'numeric_range', or 'any'.<br/>
        /// If the type is 'one_of', then 'allowed_values' will be set, and the value specified must be one of the allowed values. 'one_of' is only compatible with value_type 'string' or 'integer'.<br/>
        /// If 'numeric_range', then 'min' and 'max' will be set, then the value specified must adhere to the value_type and must fall within the `[min, max]` range (inclusive).<br/>
        /// If 'any' then any value is allowed, as long as it adheres to the value_type.<br/>
        /// Example: one_of
        /// </summary>
        /// <example>one_of</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The type of value the parameter accepts, e.g. 'string', 'integer', 'float', or 'boolean'.<br/>
        /// Example: string
        /// </summary>
        /// <example>string</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ValueType { get; set; }

        /// <summary>
        /// Whether the parameter is required (true) or optional (false).<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("required")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Required { get; set; }

        /// <summary>
        /// The allowed parameter values when the type is 'one_of'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_values")]
        public global::System.Collections.Generic.IList<global::Pinecone.AnyOf<string, int?>>? AllowedValues { get; set; }

        /// <summary>
        /// The minimum allowed value (inclusive) when the type is 'numeric_range'.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("min")]
        public double? Min { get; set; }

        /// <summary>
        /// The maximum allowed value (inclusive) when the type is 'numeric_range'.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max")]
        public double? Max { get; set; }

        /// <summary>
        /// The default value for the parameter when a parameter is optional.<br/>
        /// Example: END
        /// </summary>
        /// <example>END</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("default")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Pinecone.JsonConverters.AnyOfJsonConverter<string, int?, float?, bool?>))]
        public global::Pinecone.AnyOf<string, int?, float?, bool?>? Default { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoSupportedParameter" /> class.
        /// </summary>
        /// <param name="parameter">
        /// The name of the parameter.<br/>
        /// Example: input_type
        /// </param>
        /// <param name="type">
        /// The parameter type e.g. 'one_of', 'numeric_range', or 'any'.<br/>
        /// If the type is 'one_of', then 'allowed_values' will be set, and the value specified must be one of the allowed values. 'one_of' is only compatible with value_type 'string' or 'integer'.<br/>
        /// If 'numeric_range', then 'min' and 'max' will be set, then the value specified must adhere to the value_type and must fall within the `[min, max]` range (inclusive).<br/>
        /// If 'any' then any value is allowed, as long as it adheres to the value_type.<br/>
        /// Example: one_of
        /// </param>
        /// <param name="valueType">
        /// The type of value the parameter accepts, e.g. 'string', 'integer', 'float', or 'boolean'.<br/>
        /// Example: string
        /// </param>
        /// <param name="required">
        /// Whether the parameter is required (true) or optional (false).<br/>
        /// Example: true
        /// </param>
        /// <param name="allowedValues">
        /// The allowed parameter values when the type is 'one_of'.
        /// </param>
        /// <param name="min">
        /// The minimum allowed value (inclusive) when the type is 'numeric_range'.<br/>
        /// Example: 1
        /// </param>
        /// <param name="max">
        /// The maximum allowed value (inclusive) when the type is 'numeric_range'.<br/>
        /// Example: 1
        /// </param>
        /// <param name="default">
        /// The default value for the parameter when a parameter is optional.<br/>
        /// Example: END
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelInfoSupportedParameter(
            string parameter,
            string type,
            string valueType,
            bool required,
            global::System.Collections.Generic.IList<global::Pinecone.AnyOf<string, int?>>? allowedValues,
            double? min,
            double? max,
            global::Pinecone.AnyOf<string, int?, float?, bool?>? @default)
        {
            this.Parameter = parameter ?? throw new global::System.ArgumentNullException(nameof(parameter));
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.ValueType = valueType ?? throw new global::System.ArgumentNullException(nameof(valueType));
            this.Required = required;
            this.AllowedValues = allowedValues;
            this.Min = min;
            this.Max = max;
            this.Default = @default;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelInfoSupportedParameter" /> class.
        /// </summary>
        public ModelInfoSupportedParameter()
        {
        }
    }
}
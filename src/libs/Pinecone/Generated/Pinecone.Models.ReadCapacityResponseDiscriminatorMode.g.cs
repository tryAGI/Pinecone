
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadCapacityResponseDiscriminatorMode
    {
        /// <summary>
        /// 
        /// </summary>
        Dedicated,
        /// <summary>
        /// 
        /// </summary>
        OnDemand,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadCapacityResponseDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadCapacityResponseDiscriminatorMode value)
        {
            return value switch
            {
                ReadCapacityResponseDiscriminatorMode.Dedicated => "Dedicated",
                ReadCapacityResponseDiscriminatorMode.OnDemand => "OnDemand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadCapacityResponseDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "Dedicated" => ReadCapacityResponseDiscriminatorMode.Dedicated,
                "OnDemand" => ReadCapacityResponseDiscriminatorMode.OnDemand,
                _ => null,
            };
        }
    }
}
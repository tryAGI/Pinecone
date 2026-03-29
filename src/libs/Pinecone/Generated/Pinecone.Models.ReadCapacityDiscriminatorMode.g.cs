
#nullable enable

namespace Pinecone
{
    /// <summary>
    /// 
    /// </summary>
    public enum ReadCapacityDiscriminatorMode
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
    public static class ReadCapacityDiscriminatorModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadCapacityDiscriminatorMode value)
        {
            return value switch
            {
                ReadCapacityDiscriminatorMode.Dedicated => "Dedicated",
                ReadCapacityDiscriminatorMode.OnDemand => "OnDemand",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadCapacityDiscriminatorMode? ToEnum(string value)
        {
            return value switch
            {
                "Dedicated" => ReadCapacityDiscriminatorMode.Dedicated,
                "OnDemand" => ReadCapacityDiscriminatorMode.OnDemand,
                _ => null,
            };
        }
    }
}
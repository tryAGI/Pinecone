namespace Pinecone;

/// <summary>
/// 
/// </summary>
[Serializable]
public sealed class MetadataMap : Dictionary<string, MetadataValue>
{
    /// <summary>
    /// 
    /// </summary>
    public MetadataMap()
    {
    }
    
    private MetadataMap(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
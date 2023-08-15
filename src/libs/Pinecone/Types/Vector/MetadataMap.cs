namespace Pinecone;

[Serializable]
public sealed class MetadataMap : Dictionary<string, MetadataValue>
{
    public MetadataMap()
    {
    }
    
    private MetadataMap(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        : base(serializationInfo, streamingContext)
    {
    }
}
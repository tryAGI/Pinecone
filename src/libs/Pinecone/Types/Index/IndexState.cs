using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

[JsonConverter(typeof(IndexStateConverter))]
public enum IndexState
{
    Initializing = 0,
    ScalingUp = 1,
    ScalingDown = 2,
    Terminating = 3,
    Ready = 4
}
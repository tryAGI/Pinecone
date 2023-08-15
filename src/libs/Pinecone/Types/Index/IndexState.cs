using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(IndexStateConverter))]
public enum IndexState
{
    /// <summary>
    /// 
    /// </summary>
    Initializing = 0,
    
    /// <summary>
    /// 
    /// </summary>
    ScalingUp = 1,
    
    /// <summary>
    /// 
    /// </summary>
    ScalingDown = 2,
    
    /// <summary>
    /// 
    /// </summary>
    Terminating = 3,
    
    /// <summary>
    /// 
    /// </summary>
    Ready = 4
}
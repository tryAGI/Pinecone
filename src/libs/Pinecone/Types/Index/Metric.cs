using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

/// <summary>
/// 
/// </summary>
[JsonConverter(typeof(MetricConverter))]
public enum Metric
{
    /// <summary>
    /// 
    /// </summary>
    Cosine = 0,
    
    /// <summary>
    /// 
    /// </summary>
    DotProduct = 1,
    
    /// <summary>
    /// 
    /// </summary>
    Euclidean = 2,
}
using System.Text.Json.Serialization;
using Pinecone.Rest;

namespace Pinecone;

[JsonConverter(typeof(MetricConverter))]
public enum Metric
{
    Cosine = 0,
    DotProduct = 1,
    Euclidean = 2,
}
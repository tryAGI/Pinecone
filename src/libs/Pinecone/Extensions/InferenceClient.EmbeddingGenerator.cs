#nullable enable

using Meai = Microsoft.Extensions.AI;

namespace Pinecone;

public partial class InferenceClient : Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>
{
    private Meai.EmbeddingGeneratorMetadata? _embeddingMetadata;

    /// <inheritdoc />
    object? Meai.IEmbeddingGenerator.GetService(Type serviceType, object? serviceKey)
    {
        ArgumentNullException.ThrowIfNull(serviceType);

        return
            serviceKey is not null ? null :
            serviceType == typeof(Meai.EmbeddingGeneratorMetadata)
                ? (_embeddingMetadata ??= new("pinecone", BaseUri))
                : serviceType.IsInstanceOfType(this) ? this
                : null;
    }

    /// <inheritdoc />
    async Task<Meai.GeneratedEmbeddings<Meai.Embedding<float>>>
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>.GenerateAsync(
            IEnumerable<string> values,
            Meai.EmbeddingGenerationOptions? options,
            CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(values);

        var textList = values.ToList();

        var request = new EmbedRequest
        {
            Model = options?.ModelId ?? "multilingual-e5-large",
            Inputs = textList.Select(t => new EmbedRequestInput { Text = t }).ToList(),
        };

        var response = await EmbedAsync(
            request: request,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        var embeddings = new Meai.GeneratedEmbeddings<Meai.Embedding<float>>();

        foreach (var item in response.Data)
        {
            if (item.IsDense && item.Dense is { } dense)
            {
                var floatArray = new float[dense.Values.Count];
                for (var i = 0; i < dense.Values.Count; i++)
                {
                    floatArray[i] = dense.Values[i];
                }

                embeddings.Add(new Meai.Embedding<float>(floatArray)
                {
                    ModelId = response.Model,
                });
            }
        }

        if (response.Usage is { TotalTokens: { } totalTokens })
        {
            embeddings.Usage = new Meai.UsageDetails
            {
                InputTokenCount = totalTokens,
                TotalTokenCount = totalTokens,
            };
        }

        return embeddings;
    }
}

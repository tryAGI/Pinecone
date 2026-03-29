#nullable enable

using System.ComponentModel;
using System.Text.Json;
using Microsoft.Extensions.AI;

namespace Pinecone;

/// <summary>
/// Extensions for using PineconeClient as MEAI tools with any IChatClient.
/// </summary>
public static class PineconeToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists all indexes in the project.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListIndexesTool(this PineconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ManageIndexes.ListIndexesAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Indexes?.Select(i => new
                {
                    name = i.Name,
                    dimension = i.Dimension,
                    metric = i.Metric,
                    host = i.Host,
                    vector_type = i.VectorType,
                }) ?? []);
            },
            name: "ListIndexes",
            description: "List all Pinecone indexes in the project, returning their names, dimensions, metrics, and hosts");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that describes a specific index.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsDescribeIndexTool(this PineconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The name of the index to describe")] string indexName,
                CancellationToken cancellationToken) =>
            {
                var response = await client.ManageIndexes.DescribeIndexAsync(
                    indexName: indexName,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    name = response.Name,
                    dimension = response.Dimension,
                    metric = response.Metric,
                    host = response.Host,
                    vector_type = response.VectorType,
                    deletion_protection = response.DeletionProtection,
                    tags = response.Tags,
                });
            },
            name: "DescribeIndex",
            description: "Get detailed information about a specific Pinecone index including its configuration, status, and host URL");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that generates text embeddings using Pinecone's hosted models.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <param name="model">The embedding model to use (default: multilingual-e5-large).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsEmbedTool(
        this PineconeClient client,
        string model = "multilingual-e5-large")
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The text to generate embeddings for")] string text,
                CancellationToken cancellationToken) =>
            {
                var response = await client.Inference.EmbedAsync(
                    model: model,
                    inputs: [new EmbedRequestInput { Text = text }],
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                var embedding = response.Data.FirstOrDefault();
                var values = embedding.Dense?.Values;

                return JsonSerializer.Serialize(new
                {
                    model = response.Model,
                    vector_type = response.VectorType,
                    dimensions = values?.Count ?? 0,
                    values = values?.Take(5).ToList(),
                    truncated = (values?.Count ?? 0) > 5,
                });
            },
            name: "GenerateEmbedding",
            description: "Generate a vector embedding for text using a Pinecone hosted embedding model");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that reranks documents by relevance to a query.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <param name="model">The reranking model to use (default: bge-reranker-v2-m3).</param>
    /// <param name="topN">Maximum number of results to return (default: 5).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsRerankTool(
        this PineconeClient client,
        string model = "bge-reranker-v2-m3",
        int topN = 5)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The query to rerank documents against")] string query,
                [Description("The documents to rerank, as a JSON array of objects with a 'text' field")] string documentsJson,
                CancellationToken cancellationToken) =>
            {
                var documents = JsonSerializer.Deserialize<List<Dictionary<string, string>>>(documentsJson)
                    ?? throw new ArgumentException("Invalid documents JSON", nameof(documentsJson));

                var docs = documents.Select(d =>
                {
                    var doc = new Document();
                    foreach (var kvp in d)
                    {
                        doc.AdditionalProperties[kvp.Key] = kvp.Value;
                    }
                    return doc;
                }).ToList();

                var response = await client.Inference.RerankAsync(
                    model: model,
                    query: query,
                    documents: docs,
                    topN: topN,
                    returnDocuments: true,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(new
                {
                    model = response.Model,
                    results = response.Data.Select(r => new
                    {
                        index = r.Index,
                        score = r.Score,
                        document = r.Document?.AdditionalProperties,
                    }),
                });
            },
            name: "RerankDocuments",
            description: "Rerank documents by relevance to a query using a Pinecone reranking model");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists available embedding and reranking models.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListModelsTool(this PineconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.Inference.ListModelsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Models?.Select(m => new
                {
                    model = m.Model,
                    type = m.Type,
                    description = m.ShortDescription,
                    vector_type = m.VectorType,
                    default_dimension = m.DefaultDimension,
                    modality = m.Modality,
                    max_sequence_length = m.MaxSequenceLength,
                }) ?? []);
            },
            name: "ListModels",
            description: "List available Pinecone embedding and reranking models with their capabilities");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that lists collections in the project.
    /// </summary>
    /// <param name="client">The Pinecone client to use.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    [CLSCompliant(false)]
    public static AIFunction AsListCollectionsTool(this PineconeClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (CancellationToken cancellationToken) =>
            {
                var response = await client.ManageIndexes.ListCollectionsAsync(
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return JsonSerializer.Serialize(response.Collections?.Select(c => new
                {
                    name = c.Name,
                    status = c.Status,
                    dimension = c.Dimension,
                    vector_count = c.VectorCount,
                    size = c.Size,
                    environment = c.Environment,
                }) ?? []);
            },
            name: "ListCollections",
            description: "List all Pinecone collections in the project");
    }
}

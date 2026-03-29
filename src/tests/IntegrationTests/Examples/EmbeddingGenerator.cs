/*
order: 60
title: Embedding Generator
slug: embedding-generator

Use Pinecone's hosted embedding models via the Microsoft.Extensions.AI IEmbeddingGenerator interface.
*/

using Meai = Microsoft.Extensions.AI;

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task EmbeddingGenerator_GenerateAsync()
    {
        using var client = GetAuthenticatedClient();
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client.Inference;

        //// Generate embeddings using the MEAI IEmbeddingGenerator interface.
        var embeddings = await generator.GenerateAsync(
            ["The quick brown fox jumps over the lazy dog."],
            new Meai.EmbeddingGenerationOptions
            {
                ModelId = "multilingual-e5-large",
            });

        embeddings.Should().HaveCount(1);
        embeddings[0].Vector.Length.Should().BeGreaterThan(0);
        embeddings.Usage.Should().NotBeNull();
        embeddings.Usage!.TotalTokenCount.Should().BeGreaterThan(0);
        Console.WriteLine($"Embedding dimensions: {embeddings[0].Vector.Length}");
        Console.WriteLine($"Total tokens: {embeddings.Usage.TotalTokenCount}");
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_Metadata()
    {
        using var client = new PineconeClient("test-api-key");
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client.Inference;

        //// Retrieve metadata about the embedding provider.
        var metadata = Meai.EmbeddingGeneratorExtensions.GetService<Meai.EmbeddingGeneratorMetadata>(generator);

        metadata.Should().NotBeNull();
        metadata!.ProviderName.Should().Be("pinecone");
    }

    [TestMethod]
    public void EmbeddingGenerator_GetService_Self()
    {
        using var client = new PineconeClient("test-api-key");
        Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator = client.Inference;

        //// Retrieve the underlying InferenceClient from the generator.
        var self = Meai.EmbeddingGeneratorExtensions.GetService<InferenceClient>(generator);

        self.Should().NotBeNull();
    }
}

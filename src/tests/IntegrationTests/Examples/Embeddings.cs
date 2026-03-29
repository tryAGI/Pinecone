/*
order: 20
title: Embeddings
slug: embeddings

Generate vector embeddings using Pinecone's hosted embedding models.
*/

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_GenerateEmbeddings()
    {
        //// Generate dense text embeddings using the multilingual-e5-large model.
        using var client = GetAuthenticatedClient();

        var response = await client.Inference.EmbedAsync(
            model: "multilingual-e5-large",
            inputs:
            [
                new EmbedRequestInput { Text = "The quick brown fox jumps over the lazy dog." },
                new EmbedRequestInput { Text = "Pinecone is a vector database." },
            ]);

        response.Should().NotBeNull();
        response.Model.Should().Be("multilingual-e5-large");
        response.Data.Should().NotBeEmpty();
        Console.WriteLine($"Model: {response.Model}, Vector type: {response.VectorType}");
        foreach (var embedding in response.Data)
        {
            if (embedding.IsDense)
            {
                Console.WriteLine($"  Dense embedding: {embedding.Dense!.Values.Count} dimensions");
            }
        }
    }
}

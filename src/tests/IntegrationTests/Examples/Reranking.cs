/*
order: 30
title: Reranking
slug: reranking

Rerank documents by relevance to a query using Pinecone's hosted reranking models.
*/

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_RerankDocuments()
    {
        //// Rerank documents by relevance to a query.
        using var client = GetAuthenticatedClient();

        var doc1 = new Document();
        doc1.AdditionalProperties["text"] = "Paris is the capital of France.";

        var doc2 = new Document();
        doc2.AdditionalProperties["text"] = "Berlin is the capital of Germany.";

        var doc3 = new Document();
        doc3.AdditionalProperties["text"] = "The Eiffel Tower is in Paris.";

        var response = await client.Inference.RerankAsync(
            model: "bge-reranker-v2-m3",
            query: "What is the capital of France?",
            documents: [doc1, doc2, doc3],
            topN: 3,
            returnDocuments: true);

        response.Should().NotBeNull();
        response.Data.Should().NotBeEmpty();
        Console.WriteLine($"Reranking model: {response.Model}");
        foreach (var result in response.Data)
        {
            Console.WriteLine($"  Index: {result.Index}, Score: {result.Score:F4}");
        }
    }
}

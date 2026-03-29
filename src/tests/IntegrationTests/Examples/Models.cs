/*
order: 40
title: Models
slug: models

List and inspect available Pinecone embedding and reranking models.
*/

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListModels()
    {
        //// List all available embedding and reranking models.
        using var client = GetAuthenticatedClient();

        var response = await client.Inference.ListModelsAsync();

        response.Should().NotBeNull();
        response.Models.Should().NotBeNull();
        Console.WriteLine($"Found {response.Models?.Count ?? 0} models");
        foreach (var model in response.Models ?? [])
        {
            Console.WriteLine($"  {model.Model}: type={model.Type}, dim={model.DefaultDimension}");
        }
    }
}

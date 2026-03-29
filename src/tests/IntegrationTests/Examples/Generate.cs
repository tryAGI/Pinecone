/*
order: 10
title: Index Management
slug: index-management

Manage Pinecone indexes -- list, describe, and inspect your vector database indexes.
*/

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListIndexes()
    {
        //// List all indexes in the project.
        using var client = GetAuthenticatedClient();

        var indexes = await client.ManageIndexes.ListIndexesAsync();

        indexes.Should().NotBeNull();
        Console.WriteLine($"Found {indexes.Indexes?.Count ?? 0} indexes");
        foreach (var index in indexes.Indexes ?? [])
        {
            Console.WriteLine($"  {index.Name}: {index.Metric}, dim={index.Dimension}, host={index.Host}");
        }
    }
}

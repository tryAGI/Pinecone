/*
order: 50
title: MEAI Tools
slug: meai-tools

Use Pinecone operations as AIFunction tools with any Microsoft.Extensions.AI IChatClient.
*/

using Microsoft.Extensions.AI;

namespace Pinecone.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateMeaiTools()
    {
        //// Create MEAI AIFunction tools for use with any IChatClient.
        using var client = GetAuthenticatedClient();

        var tools = new List<AITool>
        {
            client.AsListIndexesTool(),
            client.AsDescribeIndexTool(),
            client.AsEmbedTool(),
            client.AsRerankTool(),
            client.AsListModelsTool(),
            client.AsListCollectionsTool(),
        };

        tools.Should().HaveCount(6);
        foreach (var tool in tools.Cast<AIFunction>())
        {
            Console.WriteLine($"  Tool: {tool.Name} - {tool.Description}");
        }
    }
}

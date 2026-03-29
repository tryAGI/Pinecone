# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Pinecone SDK provides `AIFunction` tool wrappers and an `IEmbeddingGenerator` implementation compatible with [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai). These tools can be used with any `IChatClient`.

## Installation

```bash
dotnet add package tryAGI.Pinecone
```

## Available Tools

| Method | Tool Name | Description |
|--------|-----------|-------------|
| `AsListIndexesTool()` | `ListIndexes` | List all indexes with dimensions and metrics |
| `AsDescribeIndexTool()` | `DescribeIndex` | Get index configuration and status |
| `AsEmbedTool()` | `GenerateEmbedding` | Generate vector embedding for text |
| `AsRerankTool()` | `RerankDocuments` | Rerank documents by relevance |
| `AsListModelsTool()` | `ListModels` | List available embedding/reranking models |
| `AsListCollectionsTool()` | `ListCollections` | List all collections |

## Usage

```csharp
using Microsoft.Extensions.AI;
using Pinecone;

var client = new PineconeClient(
    apiKey: Environment.GetEnvironmentVariable("PINECONE_API_KEY")!);

var options = new ChatOptions
{
    Tools = [client.AsListIndexesTool()],
};

IChatClient chatClient = /* your chat client */;

var messages = new List<ChatMessage>
{
    new(ChatRole.User, "List all my Pinecone indexes"),
};

while (true)
{
    var response = await chatClient.GetResponseAsync(messages, options);
    messages.AddRange(response.ToChatMessages());

    if (response.FinishReason == ChatFinishReason.ToolCalls)
    {
        var results = await response.CallToolsAsync(options);
        messages.AddRange(results);
        continue;
    }

    Console.WriteLine(response.Text);
    break;
}
```

# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Pinecone SDK implements `IEmbeddingGenerator<string, Embedding<float>>` from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai) for text embeddings, plus `AIFunction` tool wrappers for use with any `IChatClient`.

## Installation

```bash
dotnet add package tryAGI.Pinecone
```

## IEmbeddingGenerator

The `InferenceClient` (accessed via `PineconeClient.Inference`) implements `IEmbeddingGenerator<string, Embedding<float>>` for generating text embeddings.

!!! note "Namespace conflict"
    Pinecone has its own `Embedding` type that shadows `Microsoft.Extensions.AI.Embedding<T>`. Use the `Meai` alias when referencing MEAI types directly.

### Generate Embeddings

```csharp
using Pinecone;
using Meai = Microsoft.Extensions.AI;

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator =
    new PineconeClient(apiKey: Environment.GetEnvironmentVariable("PINECONE_API_KEY")!)
        .Inference;

var embeddings = await generator.GenerateAsync(["Hello, world!"]);

Console.WriteLine($"Dimensions: {embeddings[0].Vector.Length}");
Console.WriteLine($"Model: {embeddings[0].ModelId}");
```

The default model is `multilingual-e5-large`. You can specify a different model via `EmbeddingGenerationOptions`:

```csharp
var embeddings = await generator.GenerateAsync(
    ["Hello, world!"],
    new Meai.EmbeddingGenerationOptions { ModelId = "multilingual-e5-large" });
```

### Batch Embeddings

```csharp
using Pinecone;
using Meai = Microsoft.Extensions.AI;

Meai.IEmbeddingGenerator<string, Meai.Embedding<float>> generator =
    new PineconeClient(apiKey: Environment.GetEnvironmentVariable("PINECONE_API_KEY")!)
        .Inference;

var texts = new[]
{
    "The quick brown fox jumps over the lazy dog.",
    "Machine learning is a subset of artificial intelligence.",
    "Embeddings represent text as numerical vectors.",
};

var embeddings = await generator.GenerateAsync(texts);

Console.WriteLine($"Generated {embeddings.Count} embeddings");
Console.WriteLine($"Total tokens: {embeddings.Usage?.TotalTokenCount}");
```

### Provider Metadata

```csharp
var metadata = generator.GetService<Meai.EmbeddingGeneratorMetadata>();
Console.WriteLine($"Provider: {metadata?.ProviderName}"); // "pinecone"
Console.WriteLine($"Endpoint: {metadata?.ProviderUri}");
```

### Dependency Injection

```csharp
using Pinecone;
using Meai = Microsoft.Extensions.AI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Meai.IEmbeddingGenerator<string, Meai.Embedding<float>>>(
    new PineconeClient(apiKey: builder.Configuration["Pinecone:ApiKey"]!)
        .Inference);
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

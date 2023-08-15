using Pinecone;

namespace tryAGI.OpenAI.IntegrationTests;

[TestClass]
public class GeneralTests
{
    [TestMethod]
    public async Task Generate()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PINECONE_API_KEY") ??
            throw new AssertInconclusiveException("PINECONE_API_KEY environment variable is not found.");
        var environment =
            Environment.GetEnvironmentVariable("PINECONE_ENVIRONMENT") ??
            throw new AssertInconclusiveException("PINECONE_ENVIRONMENT environment variable is not found.");

        const string indexName = "test-index";

        var openAiApiKey =
            Environment.GetEnvironmentVariable("OPENAI_API_KEY") ??
            throw new AssertInconclusiveException("OPENAI_API_KEY environment variable is not found.");
        
        using var httpClient = new HttpClient();
        var pinecone = new PineconeClient(apiKey, environment, httpClient);

        // Check if the index exists and create it if it doesn't
        // Depending on the storage type and infrastructure state this may take a while
        // Free tier is limited to 1 index only
        if (!(await pinecone.ListIndexes()).Contains(indexName))
        {
            await pinecone.CreateIndex(indexName, dimension: 1536, Metric.Cosine);
        }

        // Create an OpenAI Azure client and declare a helper method to embed our text
        var openAiApi = new OpenAiApi(openAiApiKey, new HttpClient());

        // Get our Pinecone index (uses gRPC by default)
        using var index = await pinecone.GetIndexWithRestTransport(indexName);

        var first = new Vector
        {
            Id = "first",
            Values = await Embed("Hello world!"),
            Metadata = new MetadataMap
            {
                ["price"] = 50,
            }
        };

        var second = new Vector
        {
            Id = "second",
            Values = await Embed("Hello world!"),
            Metadata = new MetadataMap
            {
                ["price"] = 100,
            }
        };

        // Upsert vectors into the index
        await index.Upsert(new[] { first, second });

        // Specify metadata filter to query the index with
        var priceRange = new MetadataMap
        {
            ["price"] = new MetadataMap
            {
                ["$gte"] = 75,
                ["$lte"] = 125,
            }
        };

        // Query the index by embedding and metadata filter
        var results = await index.Query(
            await Embed("Hello world!"),
            topK: 3,
            filter: priceRange,
            includeMetadata: true);

        Console.WriteLine(string.Join('\n', results.SelectMany(v => v.Metadata!)));

        // Remove the example vectors we just added
        await index.Delete(new[] { "first", "second" });

        await pinecone.DeleteIndex(indexName);
        return;

        async Task<float[]> Embed(string text)
        {
            return await openAiApi.CreateEmbeddingAsync(text);
        }
    }
}

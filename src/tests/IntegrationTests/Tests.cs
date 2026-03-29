namespace Pinecone.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static PineconeClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("PINECONE_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("PINECONE_API_KEY environment variable is not found.");

        var client = new PineconeClient(apiKey);
        
        return client;
    }
}

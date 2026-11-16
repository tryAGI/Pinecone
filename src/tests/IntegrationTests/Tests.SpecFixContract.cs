namespace Pinecone.IntegrationTests;

/// <summary>
/// What generate.sh arranges, checked without an API key.
///
/// The credential below is not what the upstream document says on its own — generate.sh passes
/// `--security-scheme ApiKey:Header:Api-Key` to override it. Drop or change that flag and the
/// generated client authenticates the wrong way while still compiling, and the first sign would be
/// a 401 at runtime.
///
/// Every other test here needs an API key and reports inconclusive without one, so this suite
/// printed `Skipped!` and exited 0 — which reads exactly like a passing run. These two touch no
/// network.
/// </summary>
[TestClass]
public class SpecFixContractTests
{
    [TestMethod]
    public void TheClientSendsTheCredentialTheSpecFixAsksFor()
    {
        using var client = new global::Pinecone.PineconeClient("test-key");

        var authorization = client.Authorizations.SingleOrDefault(
            x => x.Type == "ApiKey" && x.Location == "Header");

        Assert.IsNotNull(
            authorization,
            $"Expected one ApiKey credential in the Header, found: " +
            string.Join(", ", client.Authorizations.Select(x => $"{x.Type}/{x.Location}/{x.Name}")) +
            ". This comes from the --security-scheme in generate.sh; if a spec refresh changed it, " +
            "fix the flag rather than this test.");
        Assert.AreEqual("Api-Key", authorization.Name);
        Assert.AreEqual("test-key", authorization.Value);
    }

    [TestMethod]
    public void TheDefaultBaseUrlIsTheOneTheSpecDeclares()
    {
        Assert.AreEqual("https://api.pinecone.io/", global::Pinecone.PineconeClient.DefaultBaseUrl);
    }
}

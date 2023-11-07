using System.Net;
using Microsoft.Azure.Cosmos.Fluent;

namespace TestProject1;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var builder = new CosmosClientBuilder("https://localhost:8081",
                "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==")
            .WithApplicationName("test");

        var client = builder.Build();
        var result = await client.CreateDatabaseIfNotExistsAsync(Guid.NewGuid().ToString());
        Assert.True(result.StatusCode == HttpStatusCode.Created);
    }
}
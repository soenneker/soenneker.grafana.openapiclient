using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Grafana.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class GrafanaOpenApiClientTests : FixturedUnitTest
{
    public GrafanaOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}

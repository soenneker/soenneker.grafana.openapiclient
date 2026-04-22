using Soenneker.Tests.HostedUnit;

namespace Soenneker.Grafana.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class GrafanaOpenApiClientTests : HostedUnitTest
{
    public GrafanaOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

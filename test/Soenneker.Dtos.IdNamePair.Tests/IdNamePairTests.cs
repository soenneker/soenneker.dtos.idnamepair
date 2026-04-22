using Soenneker.Tests.HostedUnit;

namespace Soenneker.Dtos.IdNamePair.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public class IdNamePairTests : HostedUnitTest
{
    public IdNamePairTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}

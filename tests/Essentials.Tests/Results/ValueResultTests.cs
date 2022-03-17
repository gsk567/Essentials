using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class ValueResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var result = ValueResult<int>.ResultFrom(5);
        result.Value.Should().Be(5);
    }
}
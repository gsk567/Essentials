using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class InfoResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var result = InfoResult.ResultFrom("Result message");
        result.Message.Should().Be("Result message");
    }
}
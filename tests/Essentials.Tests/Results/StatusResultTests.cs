using System.Buffers;
using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class StatusResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var result = StatusResult<OperationStatus>.ResultFrom(OperationStatus.InvalidData, "Invalid operation");
        result
            .Should()
            .BeEquivalentTo(new
            {
                Status = OperationStatus.InvalidData,
                Message = "Invalid operation"
            });
    }
}
using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class StandardResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var customResult = StandardResult.ResultFrom(false, "An error occured");
        var succeededResult = StandardResult.SuccessfulResult();
        var unsuccessfulResult = StandardResult.UnsuccessfulResult("Invalid operation");

        customResult
            .Should()
            .BeEquivalentTo(new
            {
                Succeeded = false,
                Message = "An error occured",
            });
        
        succeededResult
            .Should()
            .BeEquivalentTo(new
            {
                Succeeded = true,
                Message = null as string,
            });
        
        unsuccessfulResult
            .Should()
            .BeEquivalentTo(new
            {
                Succeeded = false,
                Message = "Invalid operation",
            });
    }
}
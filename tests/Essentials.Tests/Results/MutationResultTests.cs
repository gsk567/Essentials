using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class MutationResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var result1 = MutationResult.ResultFrom(1);
        var result2 = MutationResult.ResultFrom(null, "Item has not been created");

        result1
            .Should()
            .BeEquivalentTo(new
            {
                MutatedEntityId = 1,
                Succeeded = true,
                Message = null as string,
            });
        
        result2
            .Should()
            .BeEquivalentTo(new
            {
                MutatedEntityId = null as object,
                Succeeded = false,
                Message = "Item has not been created",
            });
    }
}
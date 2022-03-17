using System.Collections.Generic;
using System.Linq;
using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class KeyValuePairsResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var result = KeyValuePairsResult<string, int>.ResultFrom(new Dictionary<string, int>
        {
            { "one", 1 },
            { "two", 2 },
        });

        result.Pairs.Should().HaveCount(2);
        
        result
            .Pairs
            .ElementAt(0)
            .Should()
            .BeEquivalentTo(new
            {
                Key = "one",
                Value = 1,
            });
        
        result
            .Pairs
            .ElementAt(1)
            .Should()
            .BeEquivalentTo(new
            {
                Key = "two",
                Value = 2,
            });
    }
}
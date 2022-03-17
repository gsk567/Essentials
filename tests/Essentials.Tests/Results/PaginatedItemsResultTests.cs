using System;
using System.Collections.Generic;
using Essentials.Results;
using FluentAssertions;
using Xunit;

namespace Essentials.Tests.Results;

public class PaginatedItemsResultTests
{
    [Fact]
    public void ResultFrom_OnResultCreation_ShouldBeCreatedProperResult()
    {
        var items = new List<int> { 12, 5, 65, 2, 6, 71, 87, 4, 6, 23 };
        var result = PaginatedItemsResult<int>.ResultFrom(
            items,
            10,
            1,
            15
        );

        result.Count.Should().Be(10);
        result.Items.Should().BeEquivalentTo(items);
        result.PagesCount.Should().Be(2);
        result.StartRow.Should().Be(0);
        result.TotalCount.Should().Be(15);
        result.CurrentPage.Should().Be(1);
        result.PageSize.Should().Be(10);
    }
    
    [Fact]
    public void ResultFrom_OnResultCreationWithInvalidData_ShouldThrows()
    {
        var items = new List<int> { 12, 5, 65, 2, 6, 71, 87, 4, 6, 23 };
        var exception = Assert.Throws<InvalidOperationException>(() =>
        {
            PaginatedItemsResult<int>.ResultFrom(
                items,
                8,
                1,
                15
            );
        });

        exception
            .Message
            .Should()
            .Be("Items in the current result cannot exceeds the page size");
    }
}
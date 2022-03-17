using System.Collections.Generic;
using Essentials.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Xunit;

namespace Essentials.Tests.Extensions;

public class HttpContextExtensionsTests
{
    [InlineData("dog", "Dog")]
    [InlineData("Dog", "Dog")]
    [InlineData("DOG", "DOG")]
    [InlineData("_dog", "_dog")]
    [InlineData("", "")]
    [Theory]
    public void ToFirstUpper_OnStandardInput_ShouldReturnCorrectValue(string input, string expected)
    {
        Assert.Equal(input.ToFirstUpper(), expected);
    }
    
    [InlineData("dog", "dog")]
    [InlineData("Dog", "dog")]
    [InlineData("DOG", "dOG")]
    [InlineData("_dog", "_dog")]
    [InlineData("", "")]
    [Theory]
    public void ToFirstLower_OnStandardInput_ShouldReturnCorrectValue(string input, string expected)
    {
        Assert.Equal(input.ToFirstLower(), expected);
    }
}
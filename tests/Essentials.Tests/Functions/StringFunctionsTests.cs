using Essentials.Functions;
using Xunit;

namespace Essentials.Tests.Functions
{
    public class StringFunctionsTests
    {
        [InlineData("HelloWorld", "Hello World")]
        [InlineData("ThisIsSomeVeryLongText", "This Is Some Very Long Text")]
        [InlineData("UIComponent", "UI Component")]
        [InlineData("POWER", "POWER")]
        [InlineData("Hello World", "Hello World")]
        [InlineData("Hello_World", "Hello_ World")]
        [InlineData("Hello_Big Big_World", "Hello_ Big Big_ World")]
        [InlineData("Hello_Big BIGWorld", "Hello_ Big BIG World")]
        [InlineData("SOLIDPrinciple", "SOLID Principle")]
        [InlineData("powerIsPower", "power Is Power")]
        [InlineData("SOLID_PRINCIPLE", "SOLID_ PRINCIPLE")]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("     ", "")]
        [Theory]
        public void SplitWordsByCapitalLetters_OnEnteringVariousStrings_ShouldReturnValidResult(string input, string expectedOutput)
        {
            string resultOutput = StringFunctions.SplitStringByCapitalLetters(input);
            Assert.Equal(expectedOutput, resultOutput);
        }

        [InlineData("HelloWorld", "HELLO_WORLD")]
        [InlineData("ThisIsSomeVeryLongText", "THIS_IS_SOME_VERY_LONG_TEXT")]
        [InlineData("UIComponent", "UI_COMPONENT")]
        [InlineData("POWER", "POWER")]
        [InlineData("Hello World", "HELLO_WORLD")]
        [InlineData("Hello World.", "HELLO_WORLD")]
        [InlineData("Hello World!@#$%%^&||&*", "HELLO_WORLD")]
        [InlineData("Hello        World", "HELLO_WORLD")]
        [InlineData("Hello_World", "HELLO_WORLD")]
        [InlineData("Hello_Big Big_World", "HELLO_BIG_BIG_WORLD")]
        [InlineData("Hello_Big BIGWorld", "HELLO_BIG_BIG_WORLD")]
        [InlineData("SOLIDPrinciple", "SOLID_PRINCIPLE")]
        [InlineData("powerIsPower", "POWER_IS_POWER")]
        [InlineData("SOLID_PRINCIPLE", "SOLID_PRINCIPLE")]
        [InlineData("", "")]
        [InlineData(null, "")]
        [InlineData("     ", "")]
        [Theory]
        public void ConvertToKey_OnEnteringVariousStrings_ShouldReturnValidResult(string input, string expectedOutput)
        {
            string resultOutput = StringFunctions.ConvertToKey(input);
            Assert.Equal(expectedOutput, resultOutput);
        }

        [InlineData("Hello     World", "Hello World")]
        [InlineData("hello     world", "hello world")]
        [InlineData("ThisIsSomeVeryLongText", "ThisIsSomeVeryLongText")]
        [InlineData("This Is Some Very Long Text", "This Is Some Very Long Text")]
        [InlineData("This Is       Some Very      Long Text", "This Is Some Very Long Text")]
        [InlineData("", "")]
        [InlineData("     ", " ")]
        [InlineData(" ", " ")]
        [InlineData(null, "")]
        [Theory]
        public void ClearMultipleIntervals_OnEnteringVariousStrings_ShouldReturnValidResult(string input, string expectedOutput)
        {
            string resultOutput = StringFunctions.ClearMultipleIntervals(input);
            Assert.Equal(expectedOutput, resultOutput);
        }

        [InlineData("ivan", "ivan")]
        [InlineData("Иван", "ivan")]
        [InlineData("иваn", "ivan")]
        [InlineData("Борис си купи колело", "boris-si-kupi-kolelo")]
        [InlineData("Борис си купи-колело", "boris-si-kupi-kolelo")]
        [InlineData("Борис      си     купи      колело", "boris-si-kupi-kolelo")]
        [InlineData("ThisIsSomeVeryLongText", "thisissomeverylongtext")]
        [InlineData("This Is Some Very Long Text", "this-is-some-very-long-text")]
        [InlineData("This Is       Some Very      Long Text", "this-is-some-very-long-text")]
        [InlineData("Apple iPhone 13, 128GB, Blue - Unlocked (Renewed)", "apple-iphone-13-128gb-blue-unlocked-renewed")]
        [InlineData("", "")]
        [InlineData("     ", "")]
        [InlineData(" ", "")]
        [InlineData(null, "")]
        [Theory]
        public void Slugify_OnEnteringValue_ShouldReturnExpectedResult(string input, string expectedOutput)
        {
            string resultOutput = StringFunctions.Slugify(input);
            Assert.Equal(expectedOutput, resultOutput);
        }
    }
}
using Xunit;
using FluentAssertions;

namespace RomanLetters.Tests.Unit;

public class RomanLetterTests
{
    private readonly RomanLetters _sut = new();
    
    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("XL", 40)]
    [InlineData("LVIII", 58)]
    [InlineData("CMLIV", 954)]
    [InlineData("MCMXCIV", 1994)]
    public void RomanToInt_ShouldReturnExpected_WhenStringIsValue(string value, int expected)
    {
        // Act
        var result = _sut.RomanToInt(value);

        // Assert
        result.Should().Be(expected);
    }
}
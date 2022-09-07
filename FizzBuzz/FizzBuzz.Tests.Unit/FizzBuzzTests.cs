using Xunit;
using FluentAssertions;

using FizzBuzz;

namespace FizzBuzz.Tests.Unit;

public class FizzBuzzTests
{
    private readonly Kata _sut = new();
    
    [Theory]
    [InlineData(3, "Fizz")]
    [InlineData(5, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void Replace_ShouldReturnString_WhenNumberIsDivisibleByInteger(int value, string expected)
    {
        // Act
        var result = _sut.Replace(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, new object[] { "1", "2", "Fizz"})]
    [InlineData(5, new object[] { "1", "2", "Fizz", "4", "Buzz" })]
    [InlineData(15, new object[] { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz" })]
    public void FizzBuzz_ShouldReturnList_WhenNumberIsValue(int value, object[] expected)
    {
        // Act
        var result = _sut.FizzBuzz(value);

        // Assert
        result.Should().BeEquivalentTo(expected.ToList());
    }
}
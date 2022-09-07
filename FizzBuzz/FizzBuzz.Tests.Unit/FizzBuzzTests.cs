using Xunit;
using FluentAssertions;

using FizzBuzz;

namespace FizzBuzz.Tests.Unit;

public class FizzBuzzTests
{
    private readonly Kata _sut = new();
    
    [Theory]
    [InlineData(2, "Whiz")]
    [InlineData(3, "FizzWhiz")]
    [InlineData(5, "BuzzWhiz")]
    [InlineData(6, "Fizz")]
    [InlineData(10, "Buzz")]
    [InlineData(15, "FizzBuzz")]
    public void Replace_ShouldReturnString_WhenNumberIsDivisibleByInteger(int value, string expected)
    {
        // Act
        var result = _sut.Replace(value);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(3, new object[] { "1", "Whiz", "FizzWhiz" })]
    [InlineData(5, new object[] { "1", "Whiz", "FizzWhiz", "4", "BuzzWhiz" })]
    [InlineData(15, new object[] { "1", "Whiz", "FizzWhiz", "4", "BuzzWhiz", "Fizz", "Whiz", "8", "Fizz", "Buzz", "Whiz", "Fizz", "Whiz", "14", "FizzBuzz" })]
    public void FizzBuzz_ShouldReturnList_WhenNumberIsValue(int value, object[] expected)
    {
        // Act
        var result = _sut.FizzBuzz(value);

        // Assert
        result.Should().BeEquivalentTo(expected.ToList());
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(5, true)]
    [InlineData(17, true)]
    public void IsPrime_ShouldReturnTrue_WhenNumberIsPrime(int value, bool expected)
    {
        // Act
        var result = _sut.isPrime(value);

        // Assert
        result.Should().Be(expected);
    }
}
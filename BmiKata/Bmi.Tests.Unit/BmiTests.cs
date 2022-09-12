using Xunit;
using FluentAssertions;

namespace Bmi.Tests.Unit;

public class BmiTests
{
    [Theory]
    [InlineData(1.80, 77, 23.77)]
    [InlineData(1.60, 77, 30.08)]
    public void CalculateBmi_ShouldReturnDouble_WhenValuesAreDouble(double height, double weight, double expected)
    {
        // Act
        var result = Bmi.CalculateBmi(height, weight);

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(23.77, BmiRange.Healthy)]
    [InlineData(30.08, BmiRange.OverWeight)]
    public void ToBmiRange_ShouldReturnBmiRange_WhenInstanceIsDouble(double bmi, BmiRange expected)
    {
        // Act
        var result = bmi.ToBmiRange();

        // Assert
        result.Should().Be(expected);
    }

    [Theory]
    [InlineData(1.80, 77, BmiRange.Healthy)]
    [InlineData(1.60, 77, BmiRange.OverWeight)]
    public void Run_ShouldReturnDouble__WhenValuesAreDouble(double height, double weight, BmiRange expected)
    {
        // Arrange
        var result = default(BmiRange);
        Func<string, double> read = s => s == "height" ? height : weight;
        Action<BmiRange> write = r => result = r;

        // Act
        Bmi.Run(read, write);

        // Assert
        result.Should().Be(expected);
    }
}
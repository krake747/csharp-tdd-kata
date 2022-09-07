using Xunit;
using FluentAssertions;

using MetricConverter;

namespace MetricConverter.Tests.Unit;

public class MetricConverterTests
{
    private readonly MetricConverter _sut = new();
    private const double _precision = 0.00000001;

    [Theory]
    [InlineData(1, 0.621371)]
    [InlineData(2, 1.242742)]
    public void KilometersToMiles_ShouldConvertKilometersToMiles_WhenNumberIsDouble(double km, double expected)
    {
        // Act
        var miles = _sut.KilometersToMiles(km);

        // Assert
        miles.Should().BeApproximately(expected, _precision);
    }

    [Theory]
    [InlineData(30, 86)]
    [InlineData(100, 212)]
    public void CelsisusToFahreheit_ShouldConvertCelsiusToFahrenheit_WhenNumberIsDouble(double temperature, double expected)
    {
        // Act
        var fahrenheit = _sut.CelsiusToFahrenheit(temperature);

        // Assert
        fahrenheit.Should().BeApproximately(expected, _precision);
    }

    [Theory]
    [InlineData(5, 11.02311310)]
    public void KilogramsToPounds_ShouldConvertKilogramsToPounds_WhenNumberIsDouble(double kg, double expected)
    {
        // Act
        var pounds = _sut.KilogramsToPounds(kg);

        // Assert
        pounds.Should().BeApproximately(expected, _precision);
    }

    [Theory]
    [InlineData(3.785411784, TargetUnit.US, 1)]
    [InlineData(4.54609, TargetUnit.UK, 1)]
    public void LitersToGallons_ShouldConvertKilogramsToPounds_WhenNumberIsDoubleAndUnitIsTargetUnit(double liters, TargetUnit targetUnit, double expected)
    {
        // Act
        var pounds = _sut.LitersToGallons(liters, targetUnit);

        // Assert
        pounds.Should().BeApproximately(expected, _precision);
    }
}
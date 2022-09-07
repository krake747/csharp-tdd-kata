namespace MetricConverter;

public class MetricConverter
{
    /// <summary>
    /// Converts kilometers to miles.
    /// </summary>
    /// <param name="km">Kilometer</param>
    /// <returns><see langword="double"/> miles</returns>
    public double KilometersToMiles(double km) => km * 0.621371;

    /// <summary>
    /// Converts temperature from celsius to fahrenheit.
    /// </summary>
    /// <param name="tempertature">Celsisu</param>
    /// <returns><see langword="double"/> fahrenheit</returns>
    public double CelsiusToFahrenheit(double tempertature) => (tempertature * 1.8) + 32;

    /// <summary>
    /// Converts number of kilograms to pounds.
    /// </summary>
    /// <param name="kg">Kilograms</param>
    /// <returns><see langword="double"/> pounds</returns>
    public double KilogramsToPounds(double kg) => kg / 0.45359237;

    /// <summary>
    /// Converts liters to gallons.
    /// </summary>
    /// <param name="liters">Liters</param>
    /// <returns><see langword="double"/> gallons</returns>
    public double LitersToGallons(double liters, TargetUnit targetUnit) => targetUnit switch 
    {
        TargetUnit.US => liters / 3.785411784,
        TargetUnit.UK => liters / 4.54609,
        _ => throw new ArgumentException(nameof(targetUnit)),
    };
}

public enum TargetUnit
{
    US,
    UK,
}

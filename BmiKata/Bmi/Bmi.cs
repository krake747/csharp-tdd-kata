namespace Bmi;

public static class Bmi
{
    public static void Run()
    {
        Run(Read, Write);
    }

    internal static void Run(Func<string, double> read, Action<BmiRange> write)
    {
        double height = read("height");
        double weight = read("weight"); 

        var bmiRange = CalculateBmi(height, weight).ToBmiRange();

        write(bmiRange);
    }

    internal static double CalculateBmi(double height, double weight) => Math.Round(weight / Math.Pow(height, 2), 2);

    internal static BmiRange ToBmiRange(this double bmi) => bmi switch
    {
        < 18.5 => BmiRange.Underweight,
        <= 25 => BmiRange.Healthy,
        _ => BmiRange.OverWeight
    };

    private static double Read(string field)
    {
        Console.WriteLine($"Please enter your {field} (in m)");
        return double.Parse(Console.ReadLine()!);
    }

    private static void Write(BmiRange bmiRange) => Console.WriteLine($"Based on your Bmi, you are {bmiRange}");
}

public enum BmiRange
{
    Underweight,
    Healthy,
    OverWeight
}
namespace FizzBuzz;

public class Kata
{
    public IList<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1, n).Select(i => Replace(i)).ToList();
    }

    public string Replace(int n) => (n % 5, n % 3) switch
    {
        (0, 0) => "FizzBuzz",
        (_, 0) => "Fizz",
        (0, _) => "Buzz",
        _ => n.ToString(),
    };
}
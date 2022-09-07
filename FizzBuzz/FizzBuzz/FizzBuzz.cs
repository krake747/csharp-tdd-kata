namespace FizzBuzz;

public class Kata
{
    public IList<string> FizzBuzz(int n)
    {
        return Enumerable.Range(1, n).Select(i => Replace(i)).ToList();
    }

    public string Replace(int n) 
    {
        return (isPrime(n), n % 5, n % 3) switch
        {
            (true, 0, _) => "BuzzWhiz",
            (true, _, 0) => "FizzWhiz",
            (true, _, _) => "Whiz",
            (false, 0, 0) => "FizzBuzz",
            (false, _, 0) => "Fizz",
            (false, 0, _) => "Buzz",
            _ => n.ToString(),
        };
    }

    public bool isPrime(int n, int i = 2)
    {
        if (n <= 1)
            return false;
        
        if (n == i)
            return true;

        if (n % i == 0)
            return false;
        
        i++;
        return isPrime(n, i);
    }
}
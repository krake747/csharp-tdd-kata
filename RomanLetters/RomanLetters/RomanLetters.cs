using System.Transactions;

namespace RomanLetters;

public class RomanLetters
{
    public int RomanToInt(string s)
    {
        char? previousLetter = null;
        var result = 0;
        foreach (var letter in s)
        {
            result += IncreaseValue(previousLetter, letter);
            previousLetter = letter;
        }

        return result;
    }

    private int IncreaseValue(char? previousLetter, char currentLetter)
    {
        var value = LetterValue(currentLetter);
        return (previousLetter, currentLetter) switch
        {
            ('I', 'V') or ('I', 'X') => value - 2,
            ('X', 'L') or ('X', 'C') => value - 20,
            ('C', 'D') or ('C', 'M') => value - 200,
            _ => value,
        };
    }

    private int LetterValue(char c) => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentOutOfRangeException("Non-valid Roman letter"),
    };
}
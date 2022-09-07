using System.Transactions;

namespace RomanLetters;

public class RomanLetters
{
    public int RomanToInt(string s)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            var value = LetterValue(s[i]);
            if (i + 1 < s.Length && value < LetterValue(s[i + 1]))
            {
                result -= value;
            }
            else
            {
                result += value;
            }
        }

        return result;
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
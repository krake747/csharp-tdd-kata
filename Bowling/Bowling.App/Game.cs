namespace Bowling;

public class Game
{
    private readonly List<int> _rolls = new(21); 
    
    /// <summary>
    /// Score during the game.
    /// </summary>
    public int Score { get; private set; }

    /// <summary>
    /// Player rolls a ball.
    /// </summary>
    /// <param name="pins">Number of pins knocked down</param>
    public void Roll(int pins)
    {
        Score += pins;
        _rolls.Add(pins);
    }

    /// <summary>
    /// Calculates the total score of the game.
    /// </summary>
    /// <returns><see cref="int"/></returns>
    public int CalculateScore()
    {
        var score = 0;
        var roll = 0;

        for (var frame = 0; frame < 10; frame++)
        {
            if (IsStrike(roll))
            {
                // Bonus for strike is the next two rolls.
                score += _rolls[roll] + _rolls[roll + 1] + _rolls[roll + 2];
                roll++;
            }
            else if (IsSpare(roll))
            {
                // Bonus for strike is the next roll.
                score += 10 + _rolls[roll + 2];
                roll += 2;
            }
            else
            {
                score += _rolls[roll] + _rolls[roll + 1];
                roll += 2;
            }
        }

        return score;
    }

    private bool IsStrike(int roll)
    {
        return _rolls[roll] == 10;
    }

    private bool IsSpare(int roll)
    {
        return _rolls[roll] + _rolls[roll + 1] == 10;
    }
}

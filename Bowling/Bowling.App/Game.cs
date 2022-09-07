namespace Bowling;

public class Game
{
    private readonly List<int> _rollResults = new(21); 
    
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
        _rollResults.Add(pins);
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
                score += _rollResults[roll] + _rollResults[roll + 1] + _rollResults[roll + 2];
                roll++;
            }
            else if (IsSpare(roll))
            {
                // Bonus for strike is the next roll.
                score += 10 + _rollResults[roll + 2];
                roll += 2;
            }
            else
            {
                score += _rollResults[roll] + _rollResults[roll + 1];
                roll += 2;
            }
        }

        return score;
    }

    /// <summary>
    /// Check if roll is a strike.
    /// </summary>
    /// <param name="roll">Current roll</param>
    /// <returns><see langword="true"/> if strike else <see langword="false"/></returns>
    private bool IsStrike(int roll) => _rollResults[roll] == 10;

    /// <summary>
    /// Check if roll is a spare.
    /// </summary>
    /// <param name="roll">Current roll</param>
    /// <returns><see langword="true"/> if spare else <see langword="false"/></returns>
    private bool IsSpare(int roll) => _rollResults[roll] + _rollResults[roll + 1] == 10;
}

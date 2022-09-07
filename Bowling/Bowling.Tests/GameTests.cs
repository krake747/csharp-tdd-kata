using Xunit;
using FluentAssertions;

using Bowling;

namespace Bowling.Tests;

public class GameTests
{
    private readonly Game _sut = new();

    [Fact]
    public void Roll_ShouldReturnScoreOfSeven_WhenPlayerRollsSevenPins()
    {
        // Act
        _sut.Roll(7);

        // Assert
        _sut.Score.Should().Be(7);
    }

    [Fact]
    public void Roll_ShouldReturnScoreOfTwenty_WhenPlayerRollsOnePinTwentyTimes() 
    {
        // Act
        FinishGame(20, 1);

        // Assert
        _sut.Score.Should().Be(20);
    }

    [Fact]
    public void Roll_ShouldReturnScoreNine_WhenPlayerRollsTwice()
    {
        // Act
        _sut.Roll(5);
        _sut.Roll(4);
        FinishGame(18, 0);
        var totalScore = _sut.CalculateScore();

        // Assert
        totalScore.Should().Be(9);
    }

    [Fact]
    public void RollSpare_ShouldReturnSixteen_WhenPlayerRollsASpareThenThree()
    {
        // Act
        _sut.Roll(5);
        _sut.Roll(5); // Spare
        _sut.Roll(3);
        FinishGame(17, 0);
        var totalScore = _sut.CalculateScore();

        // Assert
        totalScore.Should().Be(16);
    }

    [Fact]
    public void RollStrike_ShouldReturnTwentySix_WhenPlayerRollsAStrikeThenThreeAndFive()
    {
        _sut.Roll(10); // Strike
        _sut.Roll(3);
        _sut.Roll(5);

        FinishGame(17, 0);
        var totalScore = _sut.CalculateScore();

        // Assert
        totalScore.Should().Be(26);
    }

    [Fact]
    public void RollPerfect_ShouldReturnThreeHundred_WhenPlayerRollsTwelveStrikes()
    {
        // Act
        FinishGame(12, 10);
        var totalScore = _sut.CalculateScore();

        // Assert
        totalScore.Should().Be(300);
    }

    private void FinishGame(int rolls, int pins)
    {
        for (int roll = 0; roll < rolls; roll++)
        {
            _sut.Roll(pins);
        }
    }
}
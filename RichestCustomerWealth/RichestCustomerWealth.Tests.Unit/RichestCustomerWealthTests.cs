using Xunit;
using FluentAssertions;

namespace RichestCustomerWealth.Tests.Unit;

public class RichestCustomerWealthTests
{
    private readonly RichestCustomer _sut = new();

    [Fact]
    public void MaximumWealth_ShouldReturnSix_WhenWealthiestAccountIsBothArrrays()
    {
        // Arrange
        var accounts = new int[2][]
        {
            new int [3] { 1, 2, 3 },
            new int [3] { 3, 2, 1 }
        };

        // Act
        var result = _sut.MaximumWealth(accounts);

        // Assert
        result.Should().Be(6);
    }

    [Fact]
    public void MaximumWealth_ShouldReturnTen_WhenWealthiestAccountIsSecondArrray()
    {
        // Arrange
        var accounts = new int[3][]
        {
            new int [2] { 1, 5 },
            new int [2] { 7, 3 },
            new int [2] { 3, 5 },
        };

        // Act
        var result = _sut.MaximumWealth(accounts);

        // Assert
        result.Should().Be(10);
    }

    [Fact]
    public void MaximumWealth_ShouldReturnSeventeen_WhenWealthiestAccountIsFirstArrray()
    {
        // Arrange
        var accounts = new int[3][]
        {
            new int [3] { 2, 8, 7 },
            new int [3] { 7, 1, 3 },
            new int [3] { 1, 9, 5 }
        };

        // Act
        var result = _sut.MaximumWealth(accounts);

        // Assert
        result.Should().Be(17);
    }
}


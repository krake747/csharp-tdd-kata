using Xunit;
using FluentAssertions;

namespace SoldierRows.Tests.Unit;

public class SoldierRowsTests
{
    private readonly SoldierRows _sut = new();
    
    [Theory]
    [InlineData(3, new[] { 2, 0, 3 },
        new[] { 1, 1, 0, 0, 0 },
        new[] { 1, 1, 1, 1, 0 },
        new[] { 1, 0, 0, 0, 0 },
        new[] { 1, 1, 0, 0, 0 },
        new[] { 1, 1, 1, 1, 1 }
    )]
    [InlineData(2, new[] { 0, 2 },
        new[] { 1, 0, 0, 0 },
        new[] { 1, 1, 1, 1 },
        new[] { 1, 0, 0, 0 },
        new[] { 1, 0, 0, 0 }
    )]
    public void KWeakestRows_ShouldReturnArray_WhenNumberIsInteger(int k, int[] expected , params int[][] mat)
    {
        // Act
        var results = _sut.KWeakestRows(mat, k);

        // Assert
        results.Should().BeEquivalentTo(expected);
    }
}
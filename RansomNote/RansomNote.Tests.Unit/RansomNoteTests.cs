using FluentAssertions;
using Xunit;

namespace RansomNote.Tests.Unit;

public class RansomNoteTests
{
    private readonly RansomNote _sut = new();
    
    [Theory]
    [InlineData("a", "b", false)]
    [InlineData("aa", "ab", false)]
    [InlineData("aa","aab", true)]
    public void CanConstruct_ShouldReturnBoolean_WhenTwoInputsAreString(string ransomNote, string magazine, bool expected)
    {
        // Act
        var result = _sut.CanConstruct(ransomNote, magazine);

        // Assert
        result.Should().Be(expected);
    }
}
using Problem150;
using Xunit;

namespace Problem150.Tests;


public class UnitTest1
{
    [Fact]
    public void HasDuplicate_ReturnsTrue_WhenDuplicatesExist()
    {
        var solution = new Solution();
        int[] input = { 1, 2, 3, 2 };
        bool result = solution.HasDuplicate(input);
        Assert.True(result);
    }

    [Fact]
    public void HasDuplicate_ReturnsFalse_WhenNoDuplicates()
    {
        var solution = new Solution();
        int[] input = { 1, 2, 3, 4 };
        bool result = solution.HasDuplicate(input);
        Assert.False(result);
    }

    [Fact]
    public void HasDuplicate_ReturnsFalse_WhenArrayIsEmpty()
    {
        var solution = new Solution();
        int[] input = { };
        bool result = solution.HasDuplicate(input);
        Assert.False(result);
    }

    [Fact]
    public void HasDuplicate_ReturnsFalse_WhenArrayHasOneElement()
    {
        var solution = new Solution();
        int[] input = { 5 };
        bool result = solution.HasDuplicate(input);
        Assert.False(result);
    }
}

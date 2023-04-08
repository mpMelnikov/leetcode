using Xunit;

namespace Leetcode.Tests;

public class Solution1020Tests
{
    [Fact]
    public void Test1()
    {
        // Arrange
        var grid = new int[,] {{0,0,0,0},{1,0,1,0},{0,1,1,0},{0,0,0,0}};

        // Act
        int result = new Solution1020().NumEnclaves(grid.ToJagged());

        // Assert
        Assert.Equal(result, 3);
    }
}

public class Solution1020
{
    private int _n;
    private int _m;

    public int NumEnclaves(int[][] grid)
    {
        _n = grid.Length;
        _m = grid[0].Length;

        int islandCount = 0;
        for(int i = 0; i < _n; ++i)
        {
            for(int j = 0; j < _m; ++j)
            {
                // If water, do nothing
                if (grid[i][j] == 0) continue;

                int? count = Flood(grid, i, j);
                if (count != null)
                {
                    islandCount += count.Value;
                }
            }
        }

        return islandCount;
    }

    private int? Flood(int[][] grid, int i, int j)
    {
        if (i < 0 || i == _n || j < 0 || j == _m) return null;
        if (grid[i][j] == 0) return 0;

        grid[i][j] = 0;
        var f1 = Flood(grid, i + 1, j);
        var f2 = Flood(grid, i, j + 1);
        var f3 = Flood(grid, i - 1, j);
        var f4 = Flood(grid, i, j - 1);

        if (f1 == null || f2 == null || f3 == null || f4 == null)
            return null;
        return 1 + f1 + f2 + f3 + f4;
    }
}

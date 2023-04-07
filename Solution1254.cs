public class Solution1254
{
    private int _n;
    private int _m;

    public int ClosedIsland(int[][] grid)
    {
        _n = grid.Length;
        _m = grid[0].Length;

        int islandCount = 0;
        for(int i = 0; i < _n; ++i)
        {
            for(int j = 0; j < _m; ++j)
            {
                // If water, do nothing
                if (grid[i][j] == 1) continue;

                bool isClosedIsland = Flood(grid, i, j);
                if (isClosedIsland)
                    ++islandCount;
            }
        }

        return islandCount;
    }

    private bool Flood(int[][] grid, int i, int j)
    {
        if (i < 0 || i == _n || j < 0 || j == _m) return false;
        if (grid[i][j] == 1) return true;

        grid[i][j] = 1;
        bool f1 = Flood(grid, i + 1, j);
        bool f2 = Flood(grid, i, j + 1);
        bool f3 = Flood(grid, i - 1, j);
        bool f4 = Flood(grid, i, j - 1);
        return f1 && f2 && f3 && f4;
    }
}

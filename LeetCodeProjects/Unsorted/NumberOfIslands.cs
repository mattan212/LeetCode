namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/number-of-islands/description/
    /// </summary>
    public class NumberOfIslands
    {
        public class Solution
        {
            private int _counter = 0;

            private int[,] _grid;

            private void MarkIsland(char[,] grid, int i, int j)
            {
                if (grid[i, j] == '0')
                {
                    return;
                }

                _grid[i, j] = _counter;

                if (i - 1 >= 0 && _grid[i - 1, j] == 0)
                {
                    MarkIsland(grid, i - 1, j);
                }

                if (i + 1 < grid.GetLength(0) && _grid[i + 1, j] == 0)
                {
                    MarkIsland(grid, i + 1, j);
                }

                if (j - 1 >= 0 && _grid[i, j - 1] == 0)
                {
                    MarkIsland(grid, i, j - 1);
                }

                if (j + 1 < grid.GetLength(1) && _grid[i, j + 1] == 0)
                {
                    MarkIsland(grid, i, j + 1);
                }
            }

            public int NumIslands(char[,] grid)
            {
                var rows = grid.GetLength(0);
                var columns = grid.GetLength(1);

                _grid = new int[rows, columns];

                var res = 0;

                for (var i = 0; i < rows; i++)
                {
                    for (var j = 0; j < columns; j++)
                    {
                        if (grid[i, j] == '1' && _grid[i, j] == 0)
                        {
                            _counter++;
                            MarkIsland(grid, i, j);
                        }
                    }
                }

                return _counter;
            }
        }
    }
}

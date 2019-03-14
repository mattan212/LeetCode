using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/max-area-of-island/description/
    /// </summary>
    public class MaxAreaOfIsland
    {
        public class Solution
        {
            private bool[,] _visited;

            private int GetArea(int[,] grid, int i, int j)
            {
                if (grid[i, j] == 0)
                {
                    return 0;
                }

                var res = 1;

                _visited[i, j] = true;

                if (i - 1 >= 0 && !_visited[i - 1, j])
                {
                    res += GetArea(grid, i - 1, j);
                }

                if (i + 1 < grid.GetLength(0) && !_visited[i + 1, j])
                {
                    res += GetArea(grid, i + 1, j);
                }

                if (j - 1 >= 0 && !_visited[i, j - 1])
                {
                    res += GetArea(grid, i, j - 1);
                }

                if (j + 1 < grid.GetLength(1) && !_visited[i, j + 1])
                {
                    res += GetArea(grid, i, j + 1);
                }

                return res;
            }

            public int MaxAreaOfIsland(int[,] grid)
            {
                var rows = grid.GetLength(0);
                var columns = grid.GetLength(1);

                _visited = new bool[rows, columns];

                var res = 0;

                for (var i = 0; i < rows; i++)
                {
                    for (var j = 0; j < columns; j++)
                    {
                        if (grid[i, j] == 1 && !_visited[i, j])
                        {
                            res = Math.Max(res, GetArea(grid, i, j));
                        }
                    }
                }

                return res;
            }
        }
        /**
        
 [0,0,1,0,0,0,0,1,0,0,0,0,0]
 [0,0,0,0,0,0,0,1,1,1,0,0,0]
 [0,1,1,0,1,0,0,0,0,0,0,0,0]
 [0,1,0,0,1,1,0,0,1,0,1,0,0]
 [0,1,0,0,1,1,0,0,1,1,1,0,0]
 [0,0,0,0,0,0,0,0,0,0,1,0,0]
 [0,0,0,0,0,0,0,1,1,1,0,0,0]
 [0,0,0,0,0,0,0,1,1,0,0,0,0]

 [0,0,1,0,0,0,0,1,0,0,0,0,0]
 [0,0,0,0,0,0,0,1,1,1,0,0,0]
 [0,1,1,0,1,0,0,0,0,0,0,0,0]
 [0,1,0,0,1,1,0,0,1,0,1,0,0]
 [0,1,0,0,1,1,0,0,1,1,1,0,0]
 [0,0,0,0,0,0,0,0,0,0,1,0,0]
 [0,0,0,0,0,0,0,1,1,1,0,0,0]
 [0,0,0,0,0,0,0,1,1,0,0,0,0]
         */
    }
}

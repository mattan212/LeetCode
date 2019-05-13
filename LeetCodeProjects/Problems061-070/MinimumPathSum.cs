using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-path-sum/description/
    /// </summary>
    public class MinimumPathSum
    {
        public class Solution
        {
            public int MinPathSum(int[,] grid)
            {
                var x = grid.GetLength(0);
                var y = grid.GetLength(1);

                var resGrid = new int[x, y];

                for (var i = 0; i < x; i++)
                {
                    for (var j = 0; j < y; j++)
                    {
                        if (i - 1 < 0 && j - 1 < 0)
                        {
                            resGrid[i, j] = grid[i, j];
                        }
                        else if (i - 1 < 0)
                        {
                            resGrid[i, j] = grid[i, j] + resGrid[i, j - 1];
                        }
                        else if (j - 1 < 0)
                        {
                            resGrid[i, j] = grid[i, j] + resGrid[i - 1, j];
                        }
                        else
                        {
                            resGrid[i, j] = grid[i, j] + Math.Min(resGrid[i, j - 1], resGrid[i - 1, j]);
                        }
                    }
                }

                return resGrid[x - 1, y - 1];
            }
        }
    }
}

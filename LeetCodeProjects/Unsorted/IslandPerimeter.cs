using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/island-perimeter/description/
    /// </summary>
    public class IslandPerimeter
    {
        public class Solution
        {
            public int IslandPerimeter(int[,] grid)
            {
                var res = 0;
                var rows = grid.GetLength(0);
                var columns = grid.GetLength(1);

                for (var i = 0; i < rows; i++)
                {
                    for (var j = 0; j < columns; j++)
                    {
                        if (grid[i, j] == 0)
                        {
                            continue;
                        }

                        if (i - 1 >= 0)
                        {
                            res += grid[i - 1, j] == 0 ? 1 : 0;
                        }
                        else
                        {
                            res++;
                        }

                        if (j - 1 >= 0)
                        {
                            res += grid[i, j - 1] == 0 ? 1 : 0;
                        }
                        else
                        {
                            res++;
                        }

                        if (i + 1 < rows)
                        {
                            res += grid[i + 1, j] == 0 ? 1 : 0;
                        }
                        else
                        {
                            res++;
                        }

                        if (j + 1 < columns)
                        {
                            res += grid[i, j + 1] == 0 ? 1 : 0;
                        }
                        else
                        {
                            res++;
                        }
                    }
                }

                return res;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems61_70
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths-ii/
    /// </summary>
    public class UniquePaths2
    {
        public class Solution
        {
            public int UniquePathsWithObstacles(int[,] obstacleGrid)
            {
                var m = obstacleGrid.GetLength(0);
                var n = obstacleGrid.GetLength(1);
                
                var aggregate = new int[m, n];
                aggregate[0, 0] = obstacleGrid[0,0] == 0 ? 1 : 0;
                for (var i = 0; i < m; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        var current = 0;
                        if (aggregate[i, j] != 0)
                        {
                            continue;
                        }
                        if (obstacleGrid[i, j] == 1)
                        {
                            aggregate[i, j] = 0;
                            continue;
                        }

                        if (i - 1 >= 0)
                        {
                            current += aggregate[i - 1, j];
                        }

                        if (j - 1 >= 0)
                        {
                            current += aggregate[i, j - 1];
                        }

                        aggregate[i, j] = current;
                    }
                }

                return aggregate[m - 1, n - 1];
            }
        }
    }
}

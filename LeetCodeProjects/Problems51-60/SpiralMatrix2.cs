using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems51_60
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix-ii/
    /// </summary>
    public class SpiralMatrix2
    {
        public class Solution
        {
            private enum EDirection { North, South, East, West }

            public int[,] GenerateMatrix(int n)
            {
                var res = new int[n, n];
                var count = 1;
                var direction = EDirection.East;
                
                var i = 0;
                var j = 0;
                while (count <= n * n) { 
                    res[i, j] = count++;
                    switch (direction)
                    {
                        case EDirection.East:
                            if (j >= n - 1 || res[i, j + 1] != 0)
                            {
                                direction = EDirection.South;
                                i++;
                            }
                            else
                            {
                                j++;
                            }

                            break;
                        case EDirection.South:
                            if (i >= n - 1 || res[i + 1, j] != 0)
                            {
                                direction = EDirection.West;
                                j--;
                            }
                            else
                            {
                                i++;
                            }

                            break;
                        case EDirection.West:
                            if (j - 1 < 0 || res[i, j - 1] != 0)
                            {
                                direction = EDirection.North;
                                i--;
                            }
                            else
                            {
                                j--;
                            }

                            break;
                        case EDirection.North:
                            if (i < 1 || res[i - 1, j] != 0)
                            {
                                direction = EDirection.East;
                                j++;
                            }
                            else
                            {
                                i--;
                            }

                            break;
                    }
                }

                return res;
            }
        }
    }
}

    

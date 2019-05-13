using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/spiral-matrix/
    /// </summary>
    public class SpiralMatrix
    {
        public class Solution
        {
            private enum EDirection { North, South, East, West }

            public IList<int> SpiralOrder(int[,] matrix)
            {
                var rowLength = matrix.GetLength(0);
                var colLength = matrix.GetLength(1);
                var res = new List<int>();
                var visited = new bool[rowLength, colLength];
                var count = 0;
                var direction = EDirection.East;
                var i = 0;
                var j = 0;
                while (count < rowLength * colLength)
                {
                    res.Add(matrix[i, j]);
                    visited[i, j] = true;
                    count++;
                    switch (direction)
                    {
                        case EDirection.East:
                            if (j >= colLength - 1 || visited[i, j + 1])
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
                            if (i >= rowLength - 1 || visited[i + 1, j])
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
                            if (j - 1 < 0 || visited[i, j - 1])
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
                            if (i < 1 || visited[i - 1, j])
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

    

using System;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/maximal-rectangle/
    /// </summary>
    public class MaximalRectangle
    {
        public class Solution
        {
            public int MaximalRectangle(char[,] matrix)
            {
                var m = matrix.GetLength(0);
                var n = matrix.GetLength(1);
                var res = 0;
                var horizontal = GetHorizontal(matrix);
                var vertical = GetVertical(matrix);

                for (var i = 0; i < m; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == '0')
                        {
                            continue;
                        }
                        
                        var vert = vertical[i, j];
                        for (var count = 0; count < horizontal[i, j] && j - count >= 0; count++)
                        {
                            vert = Math.Min(vert, vertical[i, j - count]);
                            res = Math.Max(res, (count + 1) * vert);
                        }
                    }
                }

                return res;
            }

            private int[,] GetHorizontal(char[,] matrix)
            {
                var m = matrix.GetLength(0);
                var n = matrix.GetLength(1);
                var res = new int[m, n];
                for (var i = 0; i < m; i++)
                {
                    var consecutive = 0;
                    for (var j = 0; j < n; j++)
                    {
                        if (matrix[i, j] == '1')
                        {
                            consecutive++;
                        }
                        else
                        {
                            consecutive = 0;
                        }

                        res[i, j] = consecutive;
                    }
                }
                return res;
            }

            private int[,] GetVertical(char[,] matrix)
            {
                var m = matrix.GetLength(0);
                var n = matrix.GetLength(1);
                var res = new int[m, n];
                for (var j = 0; j < n; j++)
                {
                    var consecutive = 0;
                    for (var i = 0; i < m; i++)
                    {
                        if (matrix[i, j] == '1')
                        {
                            consecutive++;
                        }
                        else
                        {
                            consecutive = 0;
                        }

                        res[i, j] = consecutive;
                    }
                }
                return res;
            }
        }
    }
}

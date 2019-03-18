using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/set-matrix-zeroes/
    /// </summary>
    public class SetMatrixZeroes
    {
        public class Solution
        {
            public void SetZeroes(int[,] matrix)
            {
                var rows = new HashSet<int>();
                var columns = new HashSet<int>();
                for (var i = 0; i < matrix.GetLength(0); i++)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] == 0)
                        {
                            rows.Add(i);
                            columns.Add(j);
                        }
                    }
                }

                foreach (var row in rows)
                {
                    for (var j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[row, j] = 0;
                    }
                }

                foreach (var column in columns)
                {
                    for (var i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, column] = 0;
                    }
                }
            }
        }
    }
}

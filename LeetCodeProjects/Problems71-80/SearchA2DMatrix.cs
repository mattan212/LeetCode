using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/search-a-2d-matrix/
    /// </summary>
    public class SearchA2DMatrix
    {
        public class Solution
        {
            public bool SearchMatrix(int[,] matrix, int target)
            {
                var rowsLength = matrix.GetLength(0);
                var colLength = matrix.GetLength(1);
                int i;
                for (i = 0; i < rowsLength - 1; i++)
                {
                    if (matrix[i + 1, 0] > target)
                    {
                        break;
                    }
                }

                for (var j = 0; j < colLength; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        return true;
                    }
                    else if (matrix[i, j] > target)
                    {
                        break;
                    }
                }

                return false;
            }
        }
    }
}

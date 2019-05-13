using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle-ii/
    /// </summary>
    public class PascalsTriangle2
    {
        public class Solution
        {
            public IList<int> GetRow(int rowIndex)
            {
                var current = new List<int> {1};
                if (rowIndex == 0)
                {
                    return current;
                }

                for (var i = 1; i <= rowIndex; i++)
                {
                    var next = new List<int>
                    {
                        1
                    };

                    for (var j = 1; j < i; j++)
                    {
                        next.Add(current[j - 1] + current[j]);
                    }

                    next.Add(1);
                    current = next;
                }

                return current;
            }
        }
    }
}

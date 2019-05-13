using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/pascals-triangle/
    /// </summary>
    public class PascalsTriangle
    {
        public class Solution
        {
            public IList<IList<int>> Generate(int numRows)
            {
                var res = new List<IList<int>>();
                if (numRows == 0)
                {
                    return res;
                }

                res.Add(new List<int> {1});

                for (var i = 1; i < numRows; i++)
                {
                    var current = new List<int>
                    {
                        1
                    };

                    for (var j = 1; j < i; j++)
                    {
                        current.Add(res[i - 1][j - 1] + res[i - 1][j]);
                    }

                    current.Add(1);
                    res.Add(current);
                }

                return res;
            }
        }
    }
}

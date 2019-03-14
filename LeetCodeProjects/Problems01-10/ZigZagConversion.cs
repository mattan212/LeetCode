using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/zigzag-conversion/
    /// </summary>
    public class ZigZagConversion
    {
        public class Solution
        {
            public string Convert(string s, int numRows)
            {
                if (numRows == 1)
                {
                    return s;
                }

                var container = Enumerable.Repeat("", numRows).ToArray();

                var row = 0;
                var downTrend = true;
                for (var i = 0; i < s.Length; i++)
                {
                    container[row] += s[i];

                    if (row == 0)
                    {
                        downTrend = true;
                    }
                    else if (row == numRows - 1)
                    {
                        downTrend = false;
                    }

                    row = downTrend ? row + 1 : row - 1;
                }

                var res = container.Aggregate("", (a, b) => a + b);

                return res;
            }
        }
    }
}

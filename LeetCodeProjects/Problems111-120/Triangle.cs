using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/triangle/
    /// </summary>
    public class Triangle
    {
        public class Solution
        {
            public int MinimumTotal(IList<IList<int>> triangle)
            {
                if (triangle == null || !triangle.Any())
                {
                    return 0;
                }

                if (triangle.Count == 1)
                {
                    return triangle[0][0];
                }

                var res = int.MaxValue;

                for (var i = 1; i < triangle.Count; i++)
                {
                    var prev = triangle[i - 1];
                    for (var j = 0; j < triangle[i].Count; j++)
                    {
                        var a = j - 1 >= 0 ? prev[j - 1] : int.MaxValue;
                        var b = j < prev.Count ? prev[j] : int.MaxValue;
                        triangle[i][j] += Math.Min(a, b);

                        //this uglifies the code, but it improved the runtime from returning triangle.Last().Min()

                        if (i == triangle.Count - 1)
                        {
                            res = Math.Min(res, triangle[i][j]);
                        }
                    }
                }

                return res;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems81_90
{
    /// <summary>
    /// https://leetcode.com/problems/largest-rectangle-in-histogram/
    /// </summary>
    public class LargestRectangleInHistogram
    {
        public class Solution
        {
            public int LargestRectangleArea(int[] heights)
            {
                if (!heights.Any())
                {
                    return 0;
                }

                var lowerLeft = new int[heights.Length];
                var lowerRight = new int[heights.Length];

                lowerLeft[0] = -1;
                lowerRight[heights.Length - 1] = heights.Length;

                for (var i = 1; i < heights.Length; i++)
                {
                    var j = i - 1;
                    while (j >= 0 && heights[j] >= heights[i])
                    {
                        j = lowerLeft[j];
                    }

                    lowerLeft[i] = j;
                }

                for (var i = heights.Length - 1; i >= 0; i--)
                {
                    var j = i + 1;
                    while (j < heights.Length && heights[j] >= heights[i])
                    {
                        j = lowerRight[j];
                    }

                    lowerRight[i] = j;
                }

                var res = 0;
                for (var i = 0; i < heights.Length; i++)
                {
                    res = Math.Max(res, heights[i] * (lowerRight[i] - lowerLeft[i] - 1));
                }

                return res;
            }
        }
    }
}
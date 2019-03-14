using System;
using System.Linq;

namespace LeetCodeProjects.Problems11_20
{
    /// <summary>
    /// https://leetcode.com/problems/container-with-most-water/
    /// </summary>
    public class ContainerWithMostWater
    {
        public class Solution
        {
            public int MaxArea(int[] height)
            {
                if (!height.Any())
                {
                    return 0;
                }

                var max = 0;
                for (var i = 1; i < height.Length; i++)
                {
                    var currentMax = 0;
                    for (var j = 0; j < i && height[i] * (i - j) > max; j++)
                    {
                        currentMax = Math.Max((i - j) * Math.Min(height[i], height[j]), currentMax);
                    }
                    max = Math.Max(currentMax, max);
                }

                return max;
            }
        }
    }
}

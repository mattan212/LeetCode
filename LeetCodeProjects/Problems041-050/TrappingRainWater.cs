using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    public class TrappingRainWater
    {
        public class Solution
        {
            public int Trap(int[] height)
            {
                if (height.Length < 2)
                {
                    return 0;
                }

                var ans = 0;
                var length = height.Length;
                var leftMax = new int[length];
                var rightMax = new int[length];
                leftMax[0] = height[0];
                rightMax[length - 1] = height[length - 1];

                for (var i = 1; i < length; i++)
                {
                    leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
                }
                for (var i = length - 2; i >= 0; i--)
                {
                    rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
                }

                for (var i = 1; i < length - 1; i++)
                {
                    ans += Math.Min(leftMax[i], rightMax[i]) - height[i];
                }

                return ans;
            }
        }
    }
}

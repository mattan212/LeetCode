using System;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-subarray/
    /// </summary>
    public class MaximumProductSubarray
    {
        public class Solution
        {
            public int MaxProduct(int[] nums)
            {
                if (nums.Length < 1)
                {
                    return 0;
                }

                var maxs = new int[nums.Length];
                var mins = new int[nums.Length];
                maxs[0] = nums[0];
                mins[0] = nums[0];

                for (var i = 1; i < nums.Length; i++)
                {
                    maxs[i] = TrinaryMax(maxs[i - 1] * nums[i], nums[i], mins[i - 1] * nums[i]);
                    mins[i] = TrinaryMin(mins[i - 1] * nums[i], nums[i], maxs[i - 1] * nums[i]);
                }

                var res = nums[0];
                for (var i = 0; i < nums.Length; i++)
                {
                    res = TrinaryMax(maxs[i], mins[i], res);
                }

                return res;
            }

            private int TrinaryMax(int a, int b, int c)
            {
                return Math.Max(a, Math.Max(b, c));
            }

            private int TrinaryMin(int a, int b, int c)
            {
                return Math.Min(a, Math.Min(b, c));
            }
        }

        

        /*
        F(0) = nums[0]
        F(1) = Max(nums[0] * nums[1], nums[1]) 
         */
    }
}

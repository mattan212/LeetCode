using System;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-product-of-three-numbers/
    /// </summary>
    public class MaximumProductOfThreeNumbers
    {
        public class Solution
        {
            public int MaximumProduct(int[] nums)
            {
                if (nums.Length < 3)
                {
                    return 0;
                }

                nums = nums.OrderBy(x => x).ToArray();

                return Math.Max(nums[0] * nums[1] * nums[nums.Length - 1], nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3]);
            }
        }
    }
}

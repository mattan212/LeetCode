using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems51_60
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-subarray/
    /// </summary>
    public class MaximumSubarray
    {
        public class Solution
        {
            public int MaxSubArray(int[] nums)
            {
                if (nums.Length == 0)
                {
                    return 0;
                }

                var res = nums[0];
                for (var i = 1; i < nums.Length; i++)
                {
                    nums[i] = Math.Max(nums[i], nums[i] + nums[i - 1]);
                    if (nums[i] > res)
                    {
                        res = nums[i];
                    }
                }

                return res;
            }
        }
    }
}

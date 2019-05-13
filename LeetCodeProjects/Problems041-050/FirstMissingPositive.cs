using System;
using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/first-missing-positive/
    /// </summary>
    public class FirstMissingPositive
    {
        public class Solution
        {
            public int FirstMissingPositive(int[] nums)
            {
                if (nums == null || nums.Length == 0)
                {
                    return 1;
                }

                var max = 0;
                var set = new HashSet<int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] > 0)
                    {
                        max = Math.Max(max, nums[i]);
                        set.Add(nums[i]);
                    }
                }

                for (var i = 1; i <= max; i++)
                {
                    if (!set.Contains(i))
                    {
                        return i;
                    }
                }

                return max + 1;
            }
        }
    }
}

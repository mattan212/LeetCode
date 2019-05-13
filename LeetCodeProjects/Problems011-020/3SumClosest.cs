using System;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/3sum-closest/
    /// </summary>
    public class _3SumClosest
    {
        public class Solution
        {
            public int ThreeSumClosest(int[] nums, int target)
            {
                int a = int.MaxValue, b = int.MaxValue, c = int.MaxValue;
                int delta = int.MaxValue;

                for (var i = 0; i < nums.Length; i++)
                {
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        for (var k = j + 1; k < nums.Length; k++)
                        {
                            var sum = nums[i] + nums[j] + nums[k];
                            if (sum == target)
                            {
                                return nums[i] + nums[j] + nums[k];
                            }
                            if (Math.Abs(target - sum) < delta)
                            {
                                a = nums[i];
                                b = nums[j];
                                c = nums[k];
                                delta = Math.Abs(target - sum);
                            }
                        }
                    }
                }

                return a + b + c;
            }
        }
    }
}

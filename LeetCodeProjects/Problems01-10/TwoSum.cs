using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/two-sum/
    /// </summary>
    public class TwoSum
    {
        public class Solution
        {
            public int[] TwoSum(int[] nums, int target)
            {
                var dict = new Dictionary<int, int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    dict[nums[i]] = i;
                }

                for (var i = 0; i < nums.Length; i++)
                {
                    if (dict.ContainsKey(target - nums[i]) && (dict[nums[i]] != i))
                    {
                        return new int[2] { i, dict[target - nums[i]] };
                    }
                }

                return null;
            }
        }
    }
}

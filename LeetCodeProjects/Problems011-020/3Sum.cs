using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class _3Sum
    {
        public class Solution
        {
            public IList<IList<int>> ThreeSum(int[] nums)
            {
                var res = new List<IList<int>>();
                if (nums == null || nums.Length < 3)
                {
                    return res;
                }

                nums = nums.OrderBy(x => x).ToArray();
                var mem = new Dictionary<int, int>();
                for (var i = 0; i < nums.Length; i++)
                {
                    mem[nums[i]] = i;
                }

                var solves = new HashSet<Tuple<int, int>>();
                for (int i = 0; i < nums.Length; i++)
                {
                    if (i - 1 >= 0 && nums[i] == nums[i - 1])
                    {
                        continue;
                    }
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (j - 1 > i + 1 && nums[j] == nums[j - 1])
                        {
                            continue;
                        }

                        var k = -1 * (nums[i] + nums[j]);

                        if (mem.ContainsKey(k) && mem[k] > j)
                        {
                            var tuple = new Tuple<int, int>(nums[i], nums[j]);
                            if (solves.Add(tuple))
                            {
                                res.Add(new List<int> { nums[i], nums[j], k });
                            }
                        }
                    }
                }

                return res;
            }
        }
    }
}

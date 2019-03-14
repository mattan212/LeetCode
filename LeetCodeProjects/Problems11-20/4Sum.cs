using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Problems11_20
{
    /// <summary>
    /// https://leetcode.com/problems/4sum/
    /// </summary>
    public class _4Sum
    {
        public class Solution
        {
            public IList<IList<int>> FourSum(int[] nums, int target)
            {
                var solves = new HashSet<Tuple<int, int, int>>();

                var dict = new Dictionary<int, List<int>>();

                nums.OrderBy(x => x).ToList();
                for (var i = 0; i < nums.Length; i++)
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict[nums[i]] = new List<int>();
                    }

                    dict[nums[i]].Add(i);
                }

                var res = new List<IList<int>>();
                for (var i = 0; i < nums.Length; i++)
                {
                    for (var j = i + 1; j < nums.Length; j++)
                    {
                        for (var k = j + 1; k < nums.Length; k++)
                        {
                            var l = (-1 * (nums[i] + nums[j] + nums[k]) + target);
                            if (dict.ContainsKey(l) && dict[l].Any(x => x != i && x != j && x != k))
                            {
                                var list = new List<int> {nums[i], nums[j], nums[k], l}.OrderBy(x => x).ToList();
                                var solve = new Tuple<int, int, int>(list[0], list[1], list[2]);
                                if (solves.Add(solve))
                                {
                                    res.Add(list);
                                }
                            }
                        }
                    }
                }
                return res;
            }
        }

    }
}

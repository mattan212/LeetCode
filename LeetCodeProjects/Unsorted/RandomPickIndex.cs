using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/random-pick-index/
    /// </summary>
    public class RandomPickIndex
    {
        public class Solution
        {
            private Random _rand;
            private Dictionary<int, List<int>> _mem;

            public Solution(int[] nums)
            {
                _rand = new Random();
                _mem = new Dictionary<int, List<int>>();

                if (!nums.Any())
                {
                    return;
                }

                for (var i = 0; i < nums.Length; i++)
                {
                    if (!_mem.ContainsKey(nums[i]))
                    {
                        _mem.Add(nums[i], new List<int>());
                    }
                    _mem[nums[i]].Add(i);
                }
            }

            public int Pick(int target)
            {
                var num = _rand.Next(_mem[target].Count);

                return _mem[target].ElementAt(num);
            }
        }
    }
}

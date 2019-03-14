using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/132-pattern/
    /// </summary>
    public class _132Pattern
    {
        public class Solution
        {
            private HashSet<int> _distinct = new HashSet<int>();

            private int[] Reduce(int[] nums)
            {
                var res = new List<int>();

                var previous = nums[0] - 1;

                foreach (var num in nums)
                {
                    if (num == previous)
                    {
                        continue;
                    }

                    res.Add(num);
                    previous = num;
                    _distinct.Add(num);
                }

                return res.ToArray();
            }

            public bool Find132pattern(int[] nums)
            {
                if (nums.Length < 3)
                {
                    return false;
                }

                nums = Reduce(nums);

                if (_distinct.Count() < 3)
                {
                    return false;
                }

                var mins = new int[nums.Length];

                var current = nums.First();
                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] < current)
                    {
                        current = nums[i];
                    }
                    mins[i] = current;
                }

                var visited = new List<int>();

                for (var i = nums.Length - 1; i > 0; i--)
                {
                    current = mins[i - 1];

                    if (nums[i] > mins[i - 1])
                    {
                        if (visited.Any(x => x < nums[i] && x > mins[i - 1]))
                        {
                            return true;
                        }
                    }

                    if (nums[i] > current)
                    {
                        visited.Add(nums[i]);
                    }
                }
                return false;
            }
        }
    }
}

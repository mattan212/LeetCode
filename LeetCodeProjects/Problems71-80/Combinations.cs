using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/combinations/
    /// </summary>
    public class Combinations
    {
        public class Solution
        {
            public IList<IList<int>> Combine(int n, int k)
            {
                var res = new List<IList<int>>();

                Helper(Enumerable.Range(1, n).ToArray(), Enumerable.Repeat(false, n).ToArray(), k, 0, res);

                return res;
            }

            private void Helper(int[] nums, bool[] used, int remaining, int startIndex, List<IList<int>> aggregate)
            {
                if (remaining == 0)
                {
                    var current = new List<int>();
                    for (var i = 0; i < nums.Length; i++)
                    {
                        if (used[i])
                        {
                            current.Add(nums[i]);
                        }
                    }

                    aggregate.Add(current);

                    return;
                }

                for (var i = startIndex; i < nums.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        Helper(nums, used, remaining - 1, i + 1, aggregate);
                        used[i] = false;
                    }
                }
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/permutation-sequence/
    /// </summary>
    public class PermutationSequence
    {
        public class Solution
        {
            private Dictionary<int, int> _facts = new Dictionary<int, int>
            {
                {0, 1},
                {1, 1},
                {2, 2},
                {3, 6},
                {4, 24},
                {5, 120},
                {6, 720},
                {7, 5040},
                {8, 40320},
                {9, 362880}
            };

            public string GetPermutation(int n, int k)
            {
                var range = Enumerable.Range(1, n).ToArray();

                var aggregate = new List<string>();

                Helper(range, Enumerable.Repeat(false, n).ToArray(), "", k, aggregate);

                return aggregate.Last();
            }

            private void Helper(int[] nums, bool[] used, string current, int k, List<string> aggregate)
            {
                if (used.All(x => x) || k == 0)
                {
                    aggregate.Add(current);
                    return;
                }

                for (var i = 0; i < nums.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        k -= _facts[used.Count(x => !x)];
                        if (k <= 0)
                        {
                            Helper(nums, used, current + nums[i], k + _facts[used.Count(x => !x)], aggregate);
                        }

                        if (aggregate.Any())
                        {
                            return;
                        }
                        used[i] = false;
                    }
                }
            }
        }
    }
}

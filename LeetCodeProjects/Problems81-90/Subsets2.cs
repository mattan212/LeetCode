using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/subsets-ii/
    /// </summary>
    public class Subsets2
    {
        public class Solution
        {
            private HashSet<string> _seen = new HashSet<string>();

            public IList<IList<int>> SubsetsWithDup(int[] nums)
            {
                var res = new List<IList<int>>();

                Helper(nums.OrderBy(x => x).ToArray(), Enumerable.Repeat(false, nums.Length).ToArray(), nums.Length, 0, res);

                return res;
            }

            private void Helper(int[] nums, bool[] used, int remaining, int startIndex, List<IList<int>> aggregate)
            {
                var id = nums.Where((t, i) => used[i]).Aggregate("", (s, n) => s + n);
                if (!_seen.Contains(id))
                {
                    aggregate.Add(nums.Where((t, i) => used[i]).ToList());
                    _seen.Add(id);
                }

                if (remaining == 0)
                {
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

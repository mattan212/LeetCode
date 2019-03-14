using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class Permutations2
    {
        public class Solution
        {
            private HashSet<string> _mem = new HashSet<string>();

            public IList<IList<int>> PermuteUnique(int[] nums)
            {
                var res = new List<IList<int>>();

                Helper(nums, Enumerable.Repeat(false, nums.Length).ToArray(), new Stack<int>(), "", res);

                return res;
            }

            private void Helper(int[] nums, bool[] used, Stack<int> permutation, string id, IList<IList<int>> aggregate)
            {
                if (_mem.Contains(id))
                {
                    return;
                }

                _mem.Add(id);
                if (permutation.Count == nums.Length)
                {
                    aggregate.Add(permutation.ToList());
                }

                for (var i = 0; i < used.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        permutation.Push(nums[i]);
                        Helper(nums, used, permutation, id + nums[i], aggregate);
                        permutation.Pop();
                        used[i] = false;
                    }
                }
            }
        }
    }
}

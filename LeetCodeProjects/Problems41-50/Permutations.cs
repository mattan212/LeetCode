using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Permutations
    {
        public class Solution
        {
            public IList<IList<int>> Permute(int[] nums)
            {
                var res = new List<IList<int>>();

                Helper(nums, Enumerable.Repeat(false, nums.Length).ToArray(), new List<int>(), res);

                return res;
            }

            private void Helper(int[] nums, bool[] used, List<int> permutation, IList<IList<int>> aggregate)
            {
                if (used.All(x => x))
                {
                    aggregate.Add(permutation);
                }

                for (var i = 0; i < used.Length; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        permutation.Add(nums[i]);
                        Helper(nums, used, permutation.ToList(), aggregate);
                        permutation.Remove(nums[i]);
                        used[i] = false;
                    }
                }
            }
        }
    }
}

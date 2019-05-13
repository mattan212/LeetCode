using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum/
    /// </summary>
    public class CombinationSum
    {
        public class Solution
        {
            public IList<IList<int>> CombinationSum(int[] candidates, int target)
            {
                candidates = candidates.OrderBy(x => x).Where(x => x <= target).ToArray();

                var res = new List<IList<int>>();

                Helper(candidates, 0, target, Enumerable.Repeat(0, candidates.Length).ToArray(), res);

                return res;
            }

            private void Helper(int[] candidates, int startIndex, int target, int[] used, List<IList<int>> aggregate)
            {
                if (target == 0)
                {
                    var current = new List<int>();
                    for (var i = 0; i < candidates.Length; i++)
                    {
                        for (var j = 0; j < used[i]; j++)
                        {
                            current.Add(candidates[i]);
                        }
                    }

                    aggregate.Add(current);
                }
                else if(target < 0 || startIndex >= candidates.Length)
                {
                }
                else
                {
                    for (var i = 0; i <= target / candidates[startIndex]; i++)
                    {
                        used[startIndex] += i;
                        Helper(candidates, startIndex + 1, target - (i * candidates[startIndex]), used, aggregate);
                        used[startIndex] -= i;
                    }
                }
            }
        }

    }
}

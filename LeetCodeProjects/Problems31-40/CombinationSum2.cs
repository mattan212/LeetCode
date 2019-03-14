using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems41_50
{
    /// <summary>
    /// https://leetcode.com/problems/combination-sum-ii/
    /// </summary>
    public class CombinationSum2
    {
        public class Solution
        {
            public IList<IList<int>> CombinationSum2(int[] candidates, int target)
            {
                var dict = new Dictionary<int, int>();
                var used = new Dictionary<int, int>();
                foreach (var t in candidates.OrderBy(x => x).Where(x => x <= target))
                {
                    if (!dict.ContainsKey(t))
                    {
                        dict.Add(t, 0);
                        used.Add(t, 0);
                    }

                    dict[t]++;
                }

                var res = new List<IList<int>>();

                Helper(dict, 0, target, used, res);

                return res;
            }

            private void Helper(Dictionary<int, int> candidates, int startIndex, int target, Dictionary<int, int> used, List<IList<int>> aggregate)
            {
                if (target == 0)
                {
                    var current = new List<int>();
                    foreach (var candidate in candidates)
                    {
                        for (var j = 0; j < used[candidate.Key]; j++)
                        {
                            current.Add(candidate.Key);
                        }
                    }
                    
                    aggregate.Add(current);
                }
                else if (target < 0 || startIndex >= candidates.Count)
                {
                }
                else
                {
                    var element = candidates.ElementAt(startIndex);
                    for (var i = 0; i <= Math.Min(target / element.Key, element.Value); i++)
                    {
                        used[element.Key] += i;
                        Helper(candidates, startIndex + 1, target - (i * candidates.ElementAt(startIndex).Key), used, aggregate);
                        used[element.Key] -= i;
                    }
                }
            }
        }
    }
}

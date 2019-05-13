using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    public class WeeklyContest81
    {
        /// <summary>
        /// https://leetcode.com/contest/weekly-contest-81/problems/shortest-distance-to-a-character/
        /// </summary>
        /// <param name="S"></param>
        /// <param name="C"></param>
        /// <returns>return an array of integers representing the shortest distance from the character C in the string</returns>
        public int[] ShortestToChar(string S, char C)
        {
            var max = int.MaxValue;
            var res = new int[S.Length];
            var dict = new Dictionary<int, List<int>>();

            for (var i = 0; i < S.Length; i++)
            {
                if (S[i] == C)
                {
                    if (!dict.ContainsKey(0))
                    {
                        dict.Add(0, new List<int>());
                    }

                    dict[0].Add(i);
                }
                res[i] = S[i] == C ? 0 : max;
            }

            for (var i = 0; i < dict.Count; i++)
            {
                var indexes = dict[i];
                if (!indexes.Any())
                {
                    break;
                }

                if (!dict.ContainsKey(i + 1))
                {
                    dict.Add(i + 1, new List<int>());
                }

                foreach (var index in indexes)
                {
                    if (index - 1 >= 0 && index - 1 < res.Length && res[index - 1] > i + 1)
                    {
                        res[index - 1] = i + 1;
                        dict[i + 1].Add(index - 1);
                    }

                    if (index + 1 < res.Length && res[index + 1] > i + 1)
                    {
                        res[index + 1] = i + 1;
                        dict[i + 1].Add(index + 1);
                    }
                }
            }

            return res;
        }
    }
}

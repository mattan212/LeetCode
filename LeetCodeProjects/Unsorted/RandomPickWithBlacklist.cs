using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/random-pick-with-blacklist/
    /// </summary>
    public class RandomPickWithBlacklist
    {
        public class Solution
        {
            Random _rand;
            private List<Tuple<int, int>> _ranges;
            
            public Solution(int N, int[] blacklist)
            {
                _rand = new Random();
                _ranges = new List<Tuple<int, int>>();
                
                if (blacklist.Any())
                {
                    blacklist = blacklist.OrderBy(x => x).ToArray();
                    if (blacklist[0] > 0)
                    {
                        _ranges.Add(new Tuple<int, int>(0, blacklist[0]));
                    }
                    for (var i = 0; i < blacklist.Length - 1; i++)
                    {
                        if (blacklist[i + 1] - blacklist[i] > 1)
                        {
                            _ranges.Add(new Tuple<int, int>(blacklist[i] + 1, blacklist[i + 1]));
                        }
                    }
                    if (blacklist.Last() < N - 1)
                    {
                        _ranges.Add(new Tuple<int, int>(blacklist.Last() + 1, N));
                    }
                }
                else
                {
                    _ranges.Add(new Tuple<int, int>(0, N));
                }
            }

            public int Pick()
            {
                var a = _rand.Next(_ranges.Count);

                var range = _ranges[a];

                var b = _rand.Next(range.Item2 - range.Item1);
                
                return range.Item1 + b;
            }
        }

    }
}

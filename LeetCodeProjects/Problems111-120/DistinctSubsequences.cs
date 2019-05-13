using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/distinct-subsequences/description/
    /// </summary>
    public class DistinctSubsequences
    {
        public class Solution
        {
            public int NumDistinct(string s, string t)
            {
                if (s.Length < t.Length)
                {
                    return 0;
                }

                if (s == t)
                {
                    return 1;
                }

                var set = new HashSet<char>();
                foreach (var c in t)
                {
                    set.Add(c);
                }

                var dict = new Dictionary<char, List<int>>();
                for (var i = 0; i < s.Length; i++)
                {
                    if (!set.Contains(s[i]))
                    {
                        continue;
                    }

                    if (!dict.ContainsKey(s[i]))
                    {
                        dict.Add(s[i], new List<int>());
                    }

                    dict[s[i]].Add(i);
                }

                if (dict.Count != set.Count)
                {
                    return 0;
                }

                return NumDistinct(dict, -1, t, 0);
            }

            private Dictionary<Tuple<int, int>, int> _mem = new Dictionary<Tuple<int, int>, int>();

            private int NumDistinct(Dictionary<char, List<int>> dict, int option, string t, int index)
            {
                if (index >= t.Length)
                {
                    return 0;
                }

                var tuple = new Tuple<int, int>(option, index);
                if (_mem.ContainsKey(tuple))
                {
                    return _mem[tuple];
                }

                var c = t[index];
                if (index == t.Length - 1)
                {
                    return dict[c].Count(x => x > option);
                }

                var options = dict[c].Where(x => x > option);

                var res = 0;
                foreach (var o in options)
                {
                    res += NumDistinct(dict, o, t, index + 1);
                }

                _mem.Add(tuple, res);
                return res;
            }
        }
    }
}

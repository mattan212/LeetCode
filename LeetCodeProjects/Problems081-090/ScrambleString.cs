using System;
using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/scramble-string/
    /// </summary>
    public class ScrambleString
    {
        public class Solution
        {
            private Dictionary<Tuple<string, string>, bool> _mem = new Dictionary<Tuple<string, string>, bool>();

            public bool IsScramble(string s1, string s2)
            {
                var tuple = new Tuple<string, string>(s1, s2);
                if (_mem.ContainsKey(tuple))
                {
                    return _mem[tuple];
                }

                var res = false;
                if ((s1 == s2) ||
                    ((s1.Length == 2 && s1[0] == s2[1] && s1[1] == s2[0]) ||
                     (s1.Length == 3 && s1[0] == s2[2] && s1[1] == s2[1] && s2[2] == s1[0])))
                {
                    res = true;
                }
                else if (!CountChars(s1, s2))
                {
                    res = false;
                }
                else
                {
                    for (var i = 0; i < s1.Length - 1 && !res; i++)
                    {
                        res = IsScramble(s1.Substring(0, i + 1), s2.Substring(0, i + 1)) &&
                              (s1.Length <= i + 1 || IsScramble(s1.Substring(i + 1), s2.Substring(i + 1)));

                        if (!res)
                        {
                        res = IsScramble(s1.Substring(0, i + 1), s2.Substring(s2.Length - i - 1)) &&
                              (s1.Length <= i + 1 || IsScramble(s1.Substring(i + 1), s2.Substring(0, s2.Length - i - 1)));
                        }
                    }
                }

                _mem.Add(tuple, res);

                return res;
            }

            private bool CountChars(string s1, string s2)
            {
                if (s1.Length != s2.Length)
                {
                    return false;
                }

                var arr1 = new int[128];
                var arr2 = new int[128];
                var set = new HashSet<int>();
                for (var i = 0; i < s1.Length; i++)
                {
                    arr1[s1[i]]++;
                    arr2[s2[i]]++;
                    set.Add(s1[i]);
                    set.Add(s2[i]);
                }

                foreach (var key in set)
                {
                    if (arr1[key] != arr2[key])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

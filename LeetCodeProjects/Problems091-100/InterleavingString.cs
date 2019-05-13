using System;
using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/interleaving-string/
    /// </summary>
    public class InterleavingString
    {
        public class Solution
        {
            private HashSet<Tuple<int, int>> _mem = new HashSet<Tuple<int, int>>();

            public bool IsInterleave(string s1, string s2, string s3)
            {
                if (s1.Length + s2.Length != s3.Length)
                {
                    return false;
                }

                if (s1 == "")
                {
                    return s2 == s3;
                }

                if (s2 == "")
                {
                    return s1 == s3;
                }

                return IsInterleave(s1, 0, s2, 0, s3, 0);
            }

            private bool IsInterleave(string s1, int i1, string s2, int i2, string s3, int i3)
            {
                if (i3 >= s3.Length)
                {
                    return true;
                }

                if (i1 < s1.Length && s1[i1] != s3[i3] && i2 < s2.Length && s2[i2] != s3[i3] || 
                    _mem.Contains(new Tuple<int, int>(i1, i2)))
                {
                    return false;
                }

                var res = false;
                if (i1 < s1.Length && i1 < s1.Length && s1[i1] == s3[i3])
                {
                    res = IsInterleave(s1, i1 + 1, s2, i2, s3, i3 + 1);
                }

                if (!res && i2 < s2.Length && s2[i2] == s3[i3])
                {
                    res = IsInterleave(s1, i1, s2, i2 + 1, s3, i3 + 1);
                }

                _mem.Add(new Tuple<int, int>(i1, i2));

                return res;
            }
        }
    }
}

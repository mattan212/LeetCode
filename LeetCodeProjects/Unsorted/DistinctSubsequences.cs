using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/distinct-subsequences/description/
    /// </summary>
    public class DistinctSubsequences
    {
        public class Solution
        {
            Dictionary<Tuple<string, string>, int> _dict = new Dictionary<Tuple<string, string>, int>();

            private string Reduce(string s, List<char> contains)
            {
                var res = "";
                for (var i = 0; i < s.Length; i++)
                {
                    if (contains.Contains(s[i]))
                    {
                        res += s[i];
                    }
                }
                return res;
            }

            private int NumDistinct(string s, string t, int indexS, int indexT)
            {
                if (t == s)
                {
                    _matrix[indexS, indexT] = 1;
                    return 1;
                }

                if (indexS >= s.Length && indexT >= t.Length || (indexS - s.Length == indexT - t.Length && t != s) || indexT == t.Length)
                {
                    _matrix[indexS, indexT] = 0;
                    return 0;
                }

                if (_matrix[indexS, indexT] != -1)
                {
                    return _matrix[indexS, indexT];
                }

                int res;
                if (s[indexS] != t[indexT])
                {
                    res = NumDistinct(s, t, indexS + 1, indexT);
                }
                else
                {
                    res = NumDistinct(s, t, indexS + 1, indexT + 1) + NumDistinct(s, t, indexS, indexT + 1);
                }
                _matrix[indexS, indexT] = res;

                return res;
            }

            private int[,] _matrix;

            public int NumDistinct(string s, string t)
            {
                var tChars = t.Distinct().ToList();

                s = Reduce(s, tChars);

                if (t.Length > s.Length || (t.Length == s.Length && t != s) || t == "")
                {
                    return 0;
                }

                if (t == s)
                {
                    return 1;
                }

                _matrix = new int[s.Length, t.Length];
                for (var i = 0; i < s.Length; i++)
                {
                    for (var j = 0; j < t.Length; j++)
                    {
                        _matrix[i, j] = -1;
                    }
                }

                var res = NumDistinct(s, t, 0, 0);
                
                return res;
            }
        }
    }
}

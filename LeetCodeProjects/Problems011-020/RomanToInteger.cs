using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/roman-to-integer/
    /// </summary>
    public class RomanToInteger
    {
        public class Solution
        {
            private Dictionary<string, int> _values = new Dictionary<string, int>{
                { "I", 1 },
                { "IV", 4 },
                { "V", 5 },
                { "IX", 9 },
                { "X", 10 },
                { "XL", 40 },
                { "L", 50 },
                { "XC", 90 },
                { "C", 100 },
                { "CD", 400 },
                { "D", 500 },
                { "CM", 900 },
                { "M", 1000 }
            };

            public int RomanToInt(string s)
            {
                if (string.IsNullOrEmpty(s))
                {
                    return 0;
                }

                if (s.Length == 1)
                {
                    return _values[s];
                }

                return RomanToInt(s, s.Length - 1);
            }

            private int RomanToInt(string s, int index)
            {
                if (index < 0)
                {
                    return 0;
                }

                if (index >= 1)
                {
                    var suffix = "" + s[index - 1] + s[index];
                    if (_values.ContainsKey(suffix))
                    {
                        return _values[suffix] + RomanToInt(s, index - 2);
                    }
                }
                return _values[s[index].ToString()] + RomanToInt(s, index - 1);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/longest-substring-without-repeating-characters/
    /// </summary>
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public class Solution
        {
            public int LengthOfLongestSubstring(string s)
            {
                var winner = 0;
                var set = new HashSet<char>();
                var indexes = new int[256];
                var last = 0;
                for (var i = 0; i < s.Length; i++)
                {
                    if (set.Contains(s[i]))
                    {
                        winner = Math.Max(set.Count(), winner);
                        foreach (var c in s.Substring(last, indexes[(int)s[i]] - last))
                        {
                            set.Remove(c);
                        }
                        last = indexes[(int)s[i]] + 1;
                    }

                    indexes[(int)s[i]] = i;
                    set.Add(s[i]);

                    winner = Math.Max(set.Count(), winner);
                }

                return winner;
            }
        }
    }
}

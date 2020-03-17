using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems131_140
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-partitioning-ii/
    /// </summary>
    public class PalindromePartitioning2
    {
        public class Solution
        {
            public int MinCut(string s)
            {
                if (string.IsNullOrEmpty(s) || IsPalindrome(s, 0, s.Length))
                {
                    return 0;
                }

                return Helper(s, 0, 0);
            }

            private int Helper(string s, int startIndex, int count)
            {
                var res = int.MaxValue;
                for (var i = startIndex + 1; i <= s.Length; i++)
                {
                    if (IsPalindrome(s, startIndex, i))
                    {
                        var current = MinCut(s.Substring(i));
                        res = Math.Min(res, count + current + 1);
                    }
                }
                return res;
            }

            private bool IsPalindrome(string s, int start, int end)
            {
                var res = true;
                end--;

                while (start < end)
                {
                    if (s[start++] != s[end--])
                    {
                        res = false;
                        break;
                    }
                }
                return res;
            }
        }

    }
}

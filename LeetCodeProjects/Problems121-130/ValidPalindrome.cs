using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems121_130
{
    /// <summary>
    /// https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    public class ValidPalindrome
    {
        public class Solution
        {
            public bool IsPalindrome(string s)
            {
                var start = 0;
                var end = s.Length - 1;

                while (start < end)
                {
                    var c1 = s[start];
                    var c2 = s[end];

                    if (!IsAlphaNumeric(c1))
                    {
                        start++;
                        continue;
                    }

                    if (!IsAlphaNumeric(c2))
                    {
                        end--;
                        continue;
                    }

                    if (ToLower(c1) != ToLower(c2))
                    {
                        return false;
                    }

                    start++;
                    end--;
                }

                return true;
            }

            private bool IsAlphaNumeric(char c)
            {
                return (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
            }

            private char ToLower(char c)
            {
                return c >= 'a' && c <= 'z' ? (char)(c - ('a' - 'A')) : c;
            }
        }
    }
}

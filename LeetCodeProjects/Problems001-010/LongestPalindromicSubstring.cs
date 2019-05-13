using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/longest-palindromic-substring/
    /// </summary>
    public class LongestPalindromicSubstring
    {
        public class Solution
        {
            public string LongestPalindrome(string s)
            {
                if (s.Length <= 1)
                {
                    return s;
                }

                if (s.Length == 2)
                {
                    return s[0] == s[1] ? s : "" + s[0];
                }

                string ans = "";
                int i = s.Length % 2 == 0 ? s.Length / 2 - 1 : s.Length / 2;
                int j = s.Length % 2 == 0 ? i + 1 : i;

                int maxSize = s.Length;

                while (0 <= i && j < s.Length)
                {
                    if (maxSize < ans.Length)
                    {
                        break;
                    }

                    string current = "";
                    current = GetPali(s, i, i);
                    if (current.Length > ans.Length)
                    {
                        ans = current;
                    }

                    current = GetPali(s, i, i + 1);
                    if (current.Length > ans.Length)
                    {
                        ans = current;
                    }

                    current = GetPali(s, j, j);
                    if (current.Length > ans.Length)
                    {
                        ans = current;
                    }

                    current = GetPali(s, j, j + 1);
                    if (current.Length > ans.Length)
                    {
                        ans = current;
                    }

                    i--;
                    j++;
                    maxSize -= 2;
                }

                return ans;
            }

            string GetPali(string str, int _i, int _j)
            {
                var res = "";
                while (_i >= 0 && _j < str.Length && str[_i] == str[_j])
                {
                    res = _i == _j ? "" + str[_i] : str[_i] + res + str[_j];
                    _i--;
                    _j++;
                }

                return res;
            }
        }
    }
}
    

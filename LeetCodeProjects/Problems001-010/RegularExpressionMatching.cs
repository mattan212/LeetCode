using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/regular-expression-matching/
    /// </summary>
    public class RegularExpressionMatching
    {
        public class Solution
        {
            public bool IsMatch(string s, string p)
            {
                bool[,] dp = new bool[s.Length + 1, p.Length + 1];
                dp[s.Length, p.Length] = true;

                for (int i = s.Length; i >= 0; i--)
                {
                    for (int j = p.Length - 1; j >= 0; j--)
                    {
                        bool firstMatch = (i < s.Length && (p[j] == s[i] || p[j] == '.'));
                        if (j + 1 < p.Length && p[j + 1] == '*')
                        {
                            dp[i, j] = dp[i, j + 2] || firstMatch && dp[i + 1, j];
                        }
                        else
                        {
                            dp[i, j] = firstMatch && dp[i + 1, j + 1];
                        }
                    }
                }
                return dp[0, 0];
            }
        }
    }
}

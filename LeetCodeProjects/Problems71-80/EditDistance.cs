using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/edit-distance/
    /// </summary>
    public class EditDistance
    {
        public class Solution
        {
            public int MinDistance(string word1, string word2)
            {
                var length1 = word1.Length;
                var length2 = word2.Length;

                var dp = new int[length1 + 1, length2 + 1];

                for (var i = 0; i <= length1; i++)
                {
                    dp[i, 0] = i;
                }

                for (var i = 1; i <= length2; i++)
                {
                    dp[0, i] = i;
                }

                for (var i = 0; i < length1; i++)
                {
                    for (var j = 0; j < length2; j++)
                    {
                        if (word1[i] == word2[j])
                        {
                            dp[i + 1, j + 1] = dp[i, j];
                        }
                        else
                        {
                            var a = dp[i, j];
                            var b = dp[i, j + 1];
                            var c = dp[i + 1, j];
                            dp[i + 1, j + 1] = (a < b ? (a < c ? a : c) : (b < c ? b : c)) + 1;
                        }
                    }
                }

                return dp[length1, length2];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    public class DecodeWays
    {
        public class Solution
        {
            public int NumDecodings(string s)
            {
                if (s == "" || s[0] == '0')
                {
                    return 0;
                }
                
                var dp = new int[s.Length];

                dp[0] = s[0] == '0' ? 0 : 1;

                for (var i = 1; i < s.Length; i++)
                {
                    var current = s[i];
                    var prev = s[i - 1];

                    if (current >= '1' && current <= '9')
                    {
                        dp[i] = dp[i - 1];
                    }

                    if ((prev == '1' && current >= '0' && current <= '9') ||
                        (prev == '2' && current >= '0' && current <= '6'))
                    {
                        dp[i] += i >= 2 ? dp[i - 2] : 1;
                    }
                }

                return dp.Last();
            }
        }
    }
}

using System;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    public class CoinChange
    {
        public class Solution
        {
            public int CoinChange(int[] coins, int amount)
            {
                var max = amount + 1;
                var dp = Enumerable.Repeat(max, amount + 1).ToArray();
                
                dp[0] = 0;
                for (var i = 1; i <= amount; i++)
                {
                    for (var j = 0; j < coins.Length; j++)
                    {
                        if (coins[j] <= i)
                        {
                            dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                        }
                    }
                }
                return dp[amount] > amount ? -1 : dp[amount];
            }

        }
    }
}

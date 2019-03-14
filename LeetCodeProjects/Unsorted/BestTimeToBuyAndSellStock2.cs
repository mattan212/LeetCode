using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/description/
    /// </summary>
    public class BestTimeToBuyAndSellStock2
    {
        public class Solution
        {
            private int[] Reduce(int[] prices)
            {
                var res = new List<int>();

                var firstMinIndex = -1;
                for (var i = 0; i < prices.Length - 1; i++)
                {
                    if (prices[i] < prices[i + 1])
                    {
                        firstMinIndex = i;
                        break;
                    }
                }

                if (firstMinIndex == -1)
                {
                    return prices;
                }

                res.Add(prices[firstMinIndex]);
                var upTrend = true;
                for (var i = firstMinIndex; i < prices.Length - 1; i++)
                {
                    if (upTrend && prices[i + 1] < prices[i])
                    {
                        res.Add(prices[i]);
                        upTrend = false;
                    }
                    else if (!upTrend && prices[i] < prices[i + 1])
                    {
                        res.Add(prices[i]);
                        upTrend = true;
                    }
                }

                res.Add(prices.ElementAt(prices.Length - 1));

                return res.ToArray();
            }
            
            public int MaxProfit(int[] prices)
            {
                prices = prices.Length > 2 ? Reduce(prices) : prices;

                var profit = 0;
                for (var i = 0; i < prices.Length - 1; i+=2)
                {
                    if (prices[i + 1] - prices[i] > 0)
                    {
                        profit += prices[i + 1] - prices[i];
                    }
                }

                return profit;
            }
        }
    }
}

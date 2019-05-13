using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/description/
    /// </summary>
    public class BestTimeToBuyAndSellStock3
    {
        public class Solution
        {
            private int[] Reduce(int[] prices)
            {
                var res = new List<int>();

                var firstMinIndex = -1;
                for (var i = 0; i < prices.Length; i++)
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
                prices = prices.Length > 12 ? Reduce(prices) : prices;

                var buy = new int[prices.Length];
                var sell = new int[prices.Length];

                var res = 0;

                for (var i = 0; i < prices.Length; i++)
                {
                    var max = 0;
                    for (var j = i + 1; j < prices.Length; j++)
                    {
                        var profit = prices[j] - prices[i];
                        
                        max = Math.Max(max, profit);
                        res = Math.Max(res, profit);
                    }

                    buy[i] = max;
                }

                for (var i = prices.Length - 1; i >= 0; i--)
                {
                    var max = 0;
                    for (var j = i - 1; j >= 0; j--)
                    {
                        var profit = prices[i] - prices[j];

                        max = Math.Max(max, profit);
                    }

                    sell[i] = max;
                }

                for (var i = 0; i < prices.Length; i++)
                {
                    for (var j = i + 1; j < prices.Length; j++)
                    {
                        res = Math.Max(res, sell[i] + buy[j]);
                    }
                }

                return res;
            }
        }
    }
}

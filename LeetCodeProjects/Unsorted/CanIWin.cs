using System;
using System.Collections.Generic;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/can-i-win/
    /// </summary>
    public class CanIWin
    {
        public class Solution
        {
            private Dictionary<int, bool> _resultsCache = new Dictionary<int, bool>();

            public bool CanIWin(int maxChoosableInteger, int desiredTotal)
            {
                //Check if it's even possible to achieve desired total
                if (maxChoosableInteger * (maxChoosableInteger + 1) / 2 < desiredTotal)
                {
                    return false;
                }

                if (maxChoosableInteger >= desiredTotal)
                {
                    return true;
                }

                return Helper(0, maxChoosableInteger, 0, 0, desiredTotal);
            }

            private bool Helper(int choosables, int size, int turn, int currentValue, int desiredTotal)
            {
                if (_resultsCache.ContainsKey(choosables))
                {
                    return _resultsCache[choosables];
                }

                if (desiredTotal - currentValue <= 0)
                {
                    return turn % 2 == 1;
                }

                var res = true;
                var temp = choosables;
                var i = 0;
                if (turn % 2 == 1)
                {
                    while (i < size && res)
                    {
                        if (temp % 2 == 0)
                        {
                            res = Helper(choosables | (int)Math.Pow(2, i), size, turn + 1, currentValue + i + 1, desiredTotal);
                        }

                        temp = temp >> 1;
                        i++;
                    }
                }
                else
                {
                    res = false;
                    while (i < size && !res)
                    {
                        if (temp % 2 == 0)
                        {
                            res = Helper(choosables | (int)Math.Pow(2, i), size, turn + 1, currentValue + i + 1, desiredTotal);
                        }

                        temp = temp >> 1;
                        i++;
                    }
                }

                if (!_resultsCache.ContainsKey(choosables))
                {
                    _resultsCache.Add(choosables, res);
                }

                return res;
            }
        }
    }
}

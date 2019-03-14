using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-integer/
    /// </summary>
    public class ReverseInteger
    {
        public class Solution
        {
            public int Reverse(int x)
            {
                var ans = 0;
                while (x != 0)
                {
                    if (ans > int.MaxValue / 10 || ans < int.MaxValue / -10)
                    {
                        return 0;
                    }

                    ans *= 10;
                    var mod = x % 10;
                    ans += mod;
                    x /= 10;
                }

                return ans;
            }
        }
    }
}

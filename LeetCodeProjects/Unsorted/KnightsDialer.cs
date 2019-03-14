using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/knight-dialer/
    /// </summary>
    public class KnightsDialer
    {
        public class Solution
        {
            private List<Dictionary<int, long>> _cache = new List<Dictionary<int, long>>();

            public int KnightDialer(int n)
            {
                for (var i = 0; i < 10; i++)
                {
                    _cache.Add(new Dictionary<int, long>
                    {
                        {1, 1}
                    });
                }

                long res = 0;

                for (var i = 0; i < 10; i++)
                {
                    res += KnightDialer(i, n);
                }

                return (int)(res % (Math.Pow(10, 9) + 7));
            }

            public long KnightDialer(int digit, int n)
            {
                if (_cache[digit].ContainsKey(n))
                {
                    return _cache[digit][n];
                }

                long res = 0;
                switch (digit)
                {
                    case 1:
                    case 3:
                        res =  KnightDialer(4, n - 1) + KnightDialer(8, n - 1);
                        break;
                    case 2:
                        res =  2 * KnightDialer(7, n - 1);
                        break;                    
                    case 4:
                    case 6:
                        res =  KnightDialer(3, n - 1) + KnightDialer(7, n - 1) + KnightDialer(0, n - 1);
                        break;
                    case 5:
                        res =  0;
                        break;
                    case 7:
                    case 9:
                        res =  KnightDialer(2, n - 1) + KnightDialer(4, n - 1);
                        break;
                    case 8:
                        res =  2 * KnightDialer(1, n - 1);
                        break;
                    case 0:
                        res =  2 * KnightDialer(4, n - 1);
                        break;
                }

                res = (int) (res % (Math.Pow(10, 9) + 7));

                _cache[digit].Add(n, res);

                return res;
            }
        }
    }
}

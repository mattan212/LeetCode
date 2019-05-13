namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/super-pow/
    /// </summary>
    public class SuperPow
    {
        public class Solution
        {
            public int SuperPow(int a, int[] b)
            {
                if (a % 1337 == 0) return 0;
                int p = 0;
                foreach (var i in b)
                {
                    p = (p * 10 + i) % 1140;
                }

                if (p == 0) p += 1440;

                return Power(a, p, 1337);
            }

            private int Power(int a, int n, int mod)
            {
                a %= mod;
                int ret = 1;
                while (n != 0)
                {
                    if ((n & 1) != 0) ret = ret * a % mod;
                    a = a * a % mod;
                    n >>= 1;
                }
                return ret;
            }
        }
    }
}

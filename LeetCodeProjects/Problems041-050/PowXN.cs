namespace LeetCodeProjects
{
    public class PowXN
    {
        /// <summary>
        /// https://leetcode.com/problems/powx-n/
        /// </summary>
        public class Solution
        {
            public double MyPow(double x, int n)
            {
                if (n == 0)
                {
                    return 1;
                }

                if (n == 1)
                {
                    return x;
                }

                if (n == -1)
                {
                    return 1 / x;
                }

                if (n < 0)
                {
                    return n % 2 == 0 ? MyPow(x * x, n / 2) : (1 / x) * MyPow(x, n + 1);
                }

                return n % 2 == 0 ? MyPow(x * x, n / 2) : x * MyPow(x, n - 1);
            }
        }
    }
}

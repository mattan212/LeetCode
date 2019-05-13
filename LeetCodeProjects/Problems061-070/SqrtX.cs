namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/
    /// </summary>
    public class SqrtX
    {
        public class Solution
        {
            public int MySqrt(int x)
            {
                if (x == 0 || x == 1)
                {
                    return x;
                }

                if (x < 0)
                {
                    return -2147483648;
                }

                int res = 1;
                while (res * res <= x && res * res > 0)
                {
                    res++;
                }

                return res - 1;
            }
        }
    }
}

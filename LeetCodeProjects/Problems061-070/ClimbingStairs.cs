namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class ClimbingStairs
    {
        public class Solution
        {
            int[] _mem;

            public int ClimbStairs(int n)
            {
                if (_mem == null)
                {
                    _mem = new int[n + 1];
                }
                if (n <= 1)
                {
                    return 1;
                }
                if (n == 2)
                {
                    return 2;
                }
                if (_mem[n] != 0)
                {
                    return _mem[n];
                }

                var res = ClimbStairs(n - 2) + ClimbStairs(n - 1);
                _mem[n] = res;
                return res;
            }
        }
    }
}

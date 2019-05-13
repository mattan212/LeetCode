namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/unique-paths/
    /// </summary>
    public class UniquePaths
    {
        public class Solution
        {
            public int UniquePaths(int m, int n)
            {
                if (m == 1 && n == 0)
                {
                    return 1;
                }
                var row = 1;
                var col = 1;
                _mem = new int[m, n];
                for (var i = 0; i < m; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        _mem[i, j] = -1;
                    }
                }
                return UniquePaths(row, col, m, n);
            }

            private int[,] _mem;

            private int UniquePaths(int row, int col, int m, int n)
            {
                if (row == m && col == n)
                {
                    return 1;
                }

                if (row > m || col > n)
                {
                    return 0;
                }

                if (_mem[row - 1, col - 1] != -1)
                {
                    return _mem[row - 1, col - 1];
                }

                var res = UniquePaths(row + 1, col, m, n) + UniquePaths(row, col + 1, m, n);
                _mem[row - 1, col - 1] = res;
                return res;
            }
        }
    }
}

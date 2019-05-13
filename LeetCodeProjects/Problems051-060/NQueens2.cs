namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens-ii/
    /// </summary>
    public class NQueens2
    {
        public class Solution
        {
            private int _count = 0;
            public int TotalNQueens(int n)
            {
                if (n == 1)
                {
                    return 1;
                }
                if (n <= 3)
                {
                    return 0;
                }

                var board = new char[n, n];
                for (var i = 0; i < n; i++)
                {
                    for (var j = 0; j < n; j++)
                    {
                        board[i, j] = '.';
                    }
                }
                for (var startingPosition = 0; startingPosition < n; startingPosition++)
                {
                    board[0, startingPosition] = 'Q';
                    FindLegalAssignments(board, 1);
                    board[0, startingPosition] = '.';
                }

                return _count;
            }

            private void FindLegalAssignments(char[,] board, int row)
            {
                var length = board.GetLength(0);
                for (var col = 0; col < length; col++)
                {
                    if (IsLegalAssignment(board, row, col))
                    {
                        board[row, col] = 'Q';
                        if (row == length - 1)
                        {
                            _count++;
                        }
                        else
                        {
                            FindLegalAssignments(board, row + 1);
                        }
                        board[row, col] = '.';
                    }
                }
            }

            private bool IsLegalAssignment(char[,] board, int row, int col)
            {
                var length = board.GetLength(0);
                for (var i = 0; i < board.GetLength(0); i++)
                {
                    if (board[i, col] == 'Q' || board[row, i] == 'Q')
                    {
                        return false;
                    }
                }

                var offset = 1;
                while (row + offset < length || col + offset < length || row - offset >= 0 || col - offset >= 0)
                {
                    if ((row + offset < length && col + offset < length && board[row + offset, col + offset] == 'Q') ||
                        (row + offset < length && col - offset >=0  && board[row + offset, col - offset] == 'Q') ||
                        (row - offset >= 0 && col + offset < length && board[row - offset, col + offset] == 'Q') ||
                        (row - offset >= 0 && col - offset >= 0 && board[row - offset, col - offset] == 'Q'))
                    {
                        return false;
                    }

                    offset++;
                }

                return true;
            }
        }
    }
}

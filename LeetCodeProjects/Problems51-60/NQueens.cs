using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems51_60
{
    /// <summary>
    /// https://leetcode.com/problems/n-queens/
    /// </summary>
    public class NQueens
    {
        public class Solution
        {
            public IList<IList<string>> SolveNQueens(int n)
            {
                var res = new List<IList<string>>();
                if (n == 1)
                {
                    res.Add(new List<string> {"Q"});
                }
                if (n <= 3)
                {
                    return res;
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
                    FindLegalAssignments(board, 1, res);
                    board[0, startingPosition] = '.';
                }

                return res;
            }

            private void FindLegalAssignments(char[,] board, int row, IList<IList<string>> aggregate)
            {
                var length = board.GetLength(0);
                for (var col = 0; col < length; col++)
                {
                    if (IsLegalAssignment(board, row, col))
                    {
                        board[row, col] = 'Q';
                        if (row == length - 1)
                        {
                            aggregate.Add(ParseBoard(board));
                        }
                        else
                        {
                            FindLegalAssignments(board, row + 1, aggregate);
                        }
                        board[row, col] = '.';
                    }
                }
            }

            private IList<string> ParseBoard(char[,] board)
            {
                var res = new List<string>();
                for (var i = 0; i < board.GetLength(0); i++)
                {
                    var current = "";
                    for (var j = 0; j < board.GetLength(0); j++)
                    {
                        current += board[i, j];
                    }

                    res.Add(current);
                }
                return res;
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

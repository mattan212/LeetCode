using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/word-search/
    /// </summary>
    public class WordSearch
    {
        public class Solution
        {
            public bool Exist(char[,] board, string word, int i, int j)
            {
                if (word == "")
                {
                    return true;
                }

                var first = word[0];
                var colLength = board.GetLength(0);
                var rowLength = board.GetLength(1);
                var res = false;
                if (i + 1 < colLength && j < rowLength && board[i + 1, j] == first)
                {
                    board[i + 1, j] = ' ';
                    res = word.Count() == 1 || Exist(board, word.Substring(1), i + 1, j);
                    board[i + 1, j] = first;
                }
                if (!res && i < colLength && j + 1 < rowLength && board[i, j + 1] == first)
                {
                    board[i, j + 1] = ' ';
                    res = word.Count() == 1 || Exist(board, word.Substring(1), i, j + 1);
                    board[i, j + 1] = first;
                }
                if (!res && 0 <= i - 1 && 0 <= j && board[i - 1, j] == first)
                {
                    board[i - 1, j] = ' ';
                    res = word.Count() == 1 || Exist(board, word.Substring(1), i - 1, j);
                    board[i - 1, j] = first;
                }
                if (!res && 0 <= i && 0 <= j - 1 && board[i, j - 1] == first)
                {
                    board[i, j - 1] = ' ';
                    res = word.Count() == 1 || Exist(board, word.Substring(1), i, j - 1);
                    board[i, j - 1] = first;
                }

                return res;
            }
        }
    }
}

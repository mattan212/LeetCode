using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/valid-sudoku/
    /// </summary>
    public class ValidSudoku
    {
        public class Solution
        {
            public bool IsValidSudoku(char[,] board)
            {
                for (var row = 0; row < 9; row++)
                {
                    var dict1 = GetCountingDict();
                    var dict2 = GetCountingDict();
                    for (var column = 0; column < 9; column++)
                    {
                        if (!AddToDict(dict1, board[row, column]))
                        {
                            return false;
                        }

                        if (!AddToDict(dict2, board[column, row]))
                        {
                            return false;
                        }

                        if (row % 3 == 0 && column % 3 == 0)
                        {
                            var innerDict = GetCountingDict();

                            for (var i = row; i < row + 3; i++)
                            {
                                for (var j = column; j < column + 3; j++)
                                {
                                    if (!AddToDict(innerDict, board[i, j]))
                                    {
                                        return false;
                                    }
                                }
                            }
                        }
                    }
                }

                return true;
            }

            private bool AddToDict(Dictionary<char, int> dict, char num)
            {
                if (num == '.')
                {
                    return true;
                }

                dict[num]++;
                return dict[num] <= 1;
            }

            private Dictionary<char, int> GetCountingDict()
            {
                var dict = new Dictionary<char, int>();
                for (var i = 1; i <= 9; i++)
                {
                    dict.Add((char)(i + '0'), 0);
                }
                return dict;
            }
        }
    }
}

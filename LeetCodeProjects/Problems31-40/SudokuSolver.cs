using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems31_40
{
    public class SudokuSolver
    {
        public class Solution
        {
            private bool _isSolved = false;
            private bool _firstExecution = true;
            private int _assignmentCount = 0;

            public void SolveSudoku(char[][] board)
            {
                if (IsSolved(board))
                {
                    _isSolved = true;
                    return;
                }

                Tuple<int, int> location = null;
                List<char> availableNumbers = null;
                for (var i = 0; i < 9; i++)
                {
                    for (var j = 0; j < 9; j++)
                    {
                        if (board[i][j] == '.')
                        {
                            if (_firstExecution)
                            {
                                _assignmentCount++;
                            }
                            var available = GetAvailableNumbers(board, i, j);
                            if (availableNumbers == null || (available.Count > 0 && available.Count < availableNumbers.Count))
                            {
                                availableNumbers = available;
                                location = new Tuple<int, int>(i, j);
                            }
                        }
                    }
                }

                _firstExecution = false;

                foreach (var i in availableNumbers)
                {
                    board[location.Item1][location.Item2] = i;
                    _assignmentCount--;
                    SolveSudoku(board);
                    if (_isSolved)
                    {
                        return;
                    }

                    _assignmentCount++;
                    board[location.Item1][location.Item2] = '.';
                }
            }

            private int GetQuadrant(int index)
            {
                if (index < 3)
                {
                    return 0;
                }
                if (index < 6)
                {
                    return 3;
                }

                return 6;
            }

            private bool IsSolved(char[][] board)
            {
                return _assignmentCount == 0 && IsValidSudoku(board);
            }

            private bool IsValidSudoku(char[][] board)
            {
                for (var row = 0; row < 9; row++)
                {
                    var dict1 = GetCountingDict();
                    var dict2 = GetCountingDict();
                    for (var column = 0; column < 9; column++)
                    {
                        if (!AddToDict(dict1, board[row][column]))
                        {
                            return false;
                        }

                        if (!AddToDict(dict2, board[column][row]))
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
                                    if (!AddToDict(innerDict, board[i][j]))
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

            private List<char> GetAvailableNumbers(char[][] board, int i, int j)
            {
                HashSet<char> set = new HashSet<char>
                {
                    '1','2','3','4','5','6','7','8','9'
                };

                for (var counter = 0; counter < 9; counter++)
                {
                    set.Remove(board[i][counter]);
                    set.Remove(board[counter][j]);
                }

                var startRow = GetQuadrant(i);
                var startCol = GetQuadrant(j);
                for (var quadrantRow = startRow; quadrantRow < startRow + 3; quadrantRow++)
                {
                    for (var quadrantCol = startCol; quadrantCol < startCol + 3; quadrantCol++)
                    {
                        set.Remove(board[quadrantRow][quadrantCol]);
                    }
                }

                return set.ToList();
            }

            private bool AddToDict(Dictionary<char, int> dict, char num)
            {
                if (num == '.')
                {
                    return false;
                }

                dict[num]++;
                return dict[num] <= 1;
            }

            private Dictionary<char, int> GetCountingDict()
            {
                return Enumerable.Range(1, 10).ToDictionary(x => (char)(x + '0'), y => 0); ;
            }

        }
    }
}



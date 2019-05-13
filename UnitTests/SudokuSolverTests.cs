﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SudokuSolverTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = new char[9][]
            {
                new char[9]{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                new char[9]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                new char[9]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                new char[9]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                new char[9]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                new char[9]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                new char[9]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                new char[9]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                new char[9]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
            };

            var expected = new char[9][]
            {
                new char[9] {'5', '3', '4', '6', '7', '8', '9', '1', '2'},
                new char[9] {'6', '7', '2', '1', '9', '5', '3', '4', '8'},
                new char[9] {'1', '9', '8', '3', '4', '2', '5', '6', '7'},
                new char[9] {'8', '5', '9', '7', '6', '1', '4', '2', '3'},
                new char[9] {'4', '2', '6', '8', '5', '3', '7', '9', '1'},
                new char[9] {'7', '1', '3', '9', '2', '4', '8', '5', '6'},
                new char[9] {'9', '6', '1', '5', '3', '7', '2', '8', '4'},
                new char[9] {'2', '8', '7', '4', '1', '9', '6', '3', '5'},
                new char[9] {'3', '4', '5', '2', '8', '6', '1', '7', '9'}
            };
            
            //Act
            var solver = new SudokuSolver.Solution();
            solver.SolveSudoku(input);

            //Assert
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    Assert.AreEqual(expected[i][j], input[i][j]);
                }
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var input = new char[9][]
            {
                new char[9]{'.','.','9','7','4','8','.','.','.'},
                new char[9]{'7','.','.','.','.','.','.','.','.'},
                new char[9]{'.','2','.','1','.','9','.','.','.'},
                new char[9]{'.','.','7','.','.','.','2','4','.'},
                new char[9]{'.','6','4','.','1','.','5','9','.'},
                new char[9]{'.','9','8','.','.','.','3','.','.'},
                new char[9]{'.','.','.','8','.','3','.','2','.'},
                new char[9]{'.','.','.','.','.','.','.','.','6'},
                new char[9]{'.','.','.','2','7','5','9','.','.'}
            }; 

            var expected = new char[9][]
            {
                new char[9]{'5','1','9','7','4','8','6','3','2'},
                new char[9]{'7','8','3','6','5','2','4','1','9'},
                new char[9]{'4','2','6','1','3','9','8','7','5'},
                new char[9]{'3','5','7','9','8','6','2','4','1'},
                new char[9]{'2','6','4','3','1','7','5','9','8'},
                new char[9]{'1','9','8','5','2','4','3','6','7'},
                new char[9]{'9','7','5','8','6','3','1','2','4'},
                new char[9]{'8','3','2','4','9','1','7','5','6'},
                new char[9]{'6','4','1','2','7','5','9','8','3'}
            };

            //Act
            var solver = new SudokuSolver.Solution();
            solver.SolveSudoku(input);

            //Assert
            for (var i = 0; i < 9; i++)
            {
                for (var j = 0; j < 9; j++)
                {
                    Assert.AreEqual(expected[i][j], input[i][j]);
                }
            }
        }



    }
}

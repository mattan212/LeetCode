using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class NQueensTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = 4;
            var expected = 2;

            //Act
            var solver = new NQueens.Solution();
            var res = solver.SolveNQueens(input);

            //Assert
            Assert.AreEqual(expected, res.Count);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = 8;
            var expected = 92;

            //Act
            var solver = new NQueens.Solution();
            var res = solver.SolveNQueens(input);

            //Assert
            Assert.AreEqual(expected, res.Count);
        }
    }
}

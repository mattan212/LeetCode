using System;
using LeetCodeProjects;
using LeetCodeProjects.Unsorted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class SnakesAndLaddersTests
    {
        private SnakesAndLadders.Solution _sol = new SnakesAndLadders.Solution();

        [TestMethod]
        public void Test1()
        {
            //Arrange
            var input = new int[6][]
            {
                new int[]{ -1, -1, -1, -1, -1, -1},
                new int[]{ -1, -1, -1, -1, -1, -1},
                new int[]{-1, -1, -1, -1, -1, -1},
                new int[]{-1, 35, -1, -1, 13, -1},
                new int[]{-1, -1, -1, -1, -1, -1},
                new int[]{ -1, 15, -1, -1, -1, -1}
            };
            var expected = 4;

            //Act
            var res = _sol.SnakesAndLadders(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            var input = new int[2][]
            {
                new int[]{ -1, -1},
                new int[]{ -1, 1}
            };
            var expected = 1;

            //Act
            var res = _sol.SnakesAndLadders(input);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

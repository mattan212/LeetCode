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
    public class MinimumMovesToEqualArrayElements2Tests
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            var arr = new int[] {1, 2, 3};
            var expected = 2;

            //Act
            var sol = new MinimumMovesToEqualArrayElements2.Solution();
            var res = sol.MinMoves2(arr);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            var arr = new int[] {1, 2, 3, 5, 7, 10};
            var expected = 16;

            //Act
            var sol = new MinimumMovesToEqualArrayElements2.Solution();
            var res = sol.MinMoves2(arr);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            var arr = new int[] {1, 2, 3, 5, 7, 10, 4, 16, 22, 304, 222, 915, 0, 0, 6, 66, 8};
            var expected = 1542;

            //Act
            var sol = new MinimumMovesToEqualArrayElements2.Solution();
            var res = sol.MinMoves2(arr);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            var arr = new int[] {4, 16, 22, 304, 222, 915, 0, 0};
            var expected = 1443;

            //Act
            var sol = new MinimumMovesToEqualArrayElements2.Solution();
            var res = sol.MinMoves2(arr);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test5()
        {
            //Arrange
            var arr = new int[] { 3 };
            var expected = 0;

            //Act
            var sol = new MinimumMovesToEqualArrayElements2.Solution();
            var res = sol.MinMoves2(arr);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

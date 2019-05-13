using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects;
using LeetCodeProjects.Unsorted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ZumaGameTests
    {
        private ZumaGame.Solution _sol = new ZumaGame.Solution();
        
        [TestMethod]
        public void Test1()
        {
            //Arrange
            var board = "WRRBBW";
            var hand = "RB";
            var expected = -1;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            var board = "WWRRBBWW";
            var hand = "WRBRW";
            var expected = 2;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            var board = "RBYYBBRRB";
            var hand = "YRBGB";
            var expected = 3;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            var board = "G";
            var hand = "GGGG";
            var expected = 2;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test5()
        {
            //Arrange
            var board = "RBYYBBRRB";
            var hand = "YB";
            var expected = -1;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test6()
        {
            //Arrange
            var board = "RRWWRRW";
            var hand = "WWRRR";
            var expected = 2;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test7()
        {
            //Arrange
            var board = "WWGWGW";
            var hand = "GWBWR";
            var expected = 3;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test8()
        {
            //Arrange
            var board = "RRWWRRW";
            var hand = "RR";
            var expected = 2;

            //Act
            var res = _sol.FindMinStep(board, hand);

            //Assert
            Assert.AreEqual(expected, res);
        }

    }
}

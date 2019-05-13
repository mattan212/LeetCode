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
    public class MaximalRectangleTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new char[,]
            {
                {'1', '0', '1', '0', '0'}, {'1', '0', '1', '1', '1'}, {'1', '1', '1', '1', '1'},
                {'1', '0', '0', '1', '0'}
            };
            var expected = 6;

            //Act
            var solver = new MaximalRectangle.Solution();
            var res = solver.MaximalRectangle(input);

            //Assert
            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = new char[,]
            {
                {'1', '0', '1', '0', '0'}, {'1', '1', '1', '1', '1'}, {'1', '1', '1', '1', '1'},
                {'1', '0', '0', '1', '0'}
            };
            var expected = 10;

            //Act
            var solver = new MaximalRectangle.Solution();
            var res = solver.MaximalRectangle(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var input = new char[,]
            {
                {'1', '0', '1', '0'},{'1', '0', '1', '1'},{'1', '0', '1', '1'},{'1', '1', '1', '1'}
            };
            var expected = 6;

            //Act
            var solver = new MaximalRectangle.Solution();
            var res = solver.MaximalRectangle(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var input = new char[,]
            {
                {'0', '0', '0', '0', '1', '1', '1', '0', '1'},{'0', '0', '1', '1', '1', '1', '1', '0', '1'},{'0', '0', '0', '1', '1', '1', '1', '1', '0'}
            };
            var expected = 9;

            //Act
            var solver = new MaximalRectangle.Solution();
            var res = solver.MaximalRectangle(input);

            //Assert
            Assert.AreEqual(expected, res);
        }


    }
}

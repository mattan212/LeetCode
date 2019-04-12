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
    public class DecodeWaysTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = "22";
            var expected = 2;

            //Act
            var solver = new DecodeWays.Solution();
            var res = solver.NumDecodings(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = "223";
            var expected = 3;

            //Act
            var solver = new DecodeWays.Solution();
            var res = solver.NumDecodings(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var input = "223610164235151201654";
            var expected = 48;

            //Act
            var solver = new DecodeWays.Solution();
            var res = solver.NumDecodings(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var input = "110";
            var expected = 1;

            //Act
            var solver = new DecodeWays.Solution();
            var res = solver.NumDecodings(input);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}


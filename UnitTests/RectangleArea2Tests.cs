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
    public class RectangleArea2Tests
    {
        private readonly RectangleArea2.Solution _solution = new RectangleArea2.Solution();
        private int[][] _input;
        private int _expected;

        [TestMethod]
        public void Test1()
        {
            //Arrange
            _input = new int[3][];
            _input[0] = new int[4] {0, 0, 2, 2};
            _input[1] = new int[4] {1, 0, 2, 3};
            _input[2] = new int[4] {1, 0, 3, 1};
            _expected = 6;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            _input = new int[1][];
            _input[0] = new int[4] { 0, 0, 1000000000, 1000000000 };
            _expected = 49;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            _input = new int[3][];
            _input[0] = new int[4]{0, 0, 3, 3};
            _input[1] = new int[4]{2, 0, 5, 3};
            _input[2] = new int[4]{1, 1, 4, 4};

            _expected = 18;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            _input = new int[3][];
            _input[0] = new int[4]{2, 0, 3, 3};
            _input[1] = new int[4]{1, 1, 3, 3};
            _input[2] = new int[4]{2, 1, 4, 3};

            _expected = 7;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test5()
        {
            //Arrange
            var x = new int[6][];
            x[0] = new int[4] { 0, 0, 2, 2 };
            x[1] = new int[4] { 1, 0, 2, 3 };
            x[2] = new int[4] { 1, 0, 3, 1 };
            x[3] = new int[4] { 3, 1, 4, 4 };
            x[4] = new int[4] { -1, 1, 2, 3 };
            x[5] = new int[4] { -1, 0, 1, 1 };

            _input = x;

            _expected = 13;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test6()
        {
            //Arrange
            var x = new int[6][];
            x[0] = new int[4] {32, 24, 69, 35};
            x[1] = new int[4] {30, 77, 82, 86};
            x[2] = new int[4] { 3, 20, 92, 35 };
            x[3] = new int[4] { 67, 23, 84, 58 };
            x[4] = new int[4] { 10,26,94,35 };
            x[5] = new int[4] { 22,14,78,62 };

            _input = x;

            _expected = 3807;

            //Act
            var res = _solution.RectangleArea(_input);

            //Assert
            Assert.AreEqual(_expected, res);
        }
    }
}

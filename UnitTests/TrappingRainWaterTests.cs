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
    public class TrappingRainWaterTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[12] {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
            var expected = 6;

            //Act
            var solver = new TrappingRainWater.Solution();
            var res = solver.Trap(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = new int[4] { 5,4,1,2 };
            var expected = 1;

            //Act
            var solver = new TrappingRainWater.Solution();
            var res = solver.Trap(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var input = new int[6] { 5, 2, 1, 2, 1, 5};
            var expected = 14;

            //Act
            var solver = new TrappingRainWater.Solution();
            var res = solver.Trap(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var input = new int[10] { 5, 5, 1, 7, 1, 1, 5, 2, 7, 6 };
            var expected = 23;

            //Act
            var solver = new TrappingRainWater.Solution();
            var res = solver.Trap(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            //Arrange
            var input = new int[7] { 9, 6, 8, 8, 5, 6, 3 };
            var expected = 3;

            //Act
            var solver = new TrappingRainWater.Solution();
            var res = solver.Trap(input);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

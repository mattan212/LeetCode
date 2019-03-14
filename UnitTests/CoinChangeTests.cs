using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects;
using LeetCodeProjects.LeetModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CoinChangeTests
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            var coins = new int[3] {1, 2, 5};
            var target = 11;
            var expected = 3;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            var coins = new int[1] { 2 };
            var target = 3;
            var expected = -1;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            var coins = new int[5] { 1, 2, 4, 6, 9 };
            var target = 420;
            var expected = 47;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            var coins = new int[2] { 1, 2147483647 };
            var target = 2;
            var expected = 2;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test5()
        {
            //Arrange
            var coins = new int[4] { 186, 419, 83, 408 };
            var target = 6249;
            var expected = 20;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test6()
        {
            //Arrange
            var coins = new int[5] { 5, 306, 188, 467, 494 };
            var target = 7047;
            var expected = 18;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test7()
        {
            //Arrange
            var coins = new int[5] { 265, 398, 46, 78, 52 };
            var target = 7754;
            var expected = 25;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test8()
        {
            //Arrange
            var coins = new int[8] { 86, 210, 29, 22, 402, 140, 16, 466 };
            var target = 3219;
            var expected = 11;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test9()
        {
            //Arrange
            var coins = new int[9] { 139, 442, 147, 461, 244, 225, 28, 378, 371 };
            var target = 9914;
            var expected = 22;

            //Act
            var solver = new CoinChange.Solution();

            var res = solver.CoinChange(coins, target);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

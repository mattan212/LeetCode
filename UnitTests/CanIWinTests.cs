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
    public class CanIWinTests
    {
        [TestMethod]
        public void Test1()
        {
            var desiredTotal = 11;
            var maxChoosableInteger = 10;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test2()
        {
            var desiredTotal = 100;
            var maxChoosableInteger = 15;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test3()
        {
            var desiredTotal = 40;
            var maxChoosableInteger = 10;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test4()
        {
            var desiredTotal = 12;
            var maxChoosableInteger = 10;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test5()
        {
            var desiredTotal = 10;
            var maxChoosableInteger = 4;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test6()
        {
            var desiredTotal = 15;
            var maxChoosableInteger = 6;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test7()
        {
            var desiredTotal = 300;
            var maxChoosableInteger = 20;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test8()
        {
            var desiredTotal = 54;
            var maxChoosableInteger = 10;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test9()
        {
            var desiredTotal = 210;
            var maxChoosableInteger = 20;

            //Act
            var sol = new CanIWin.Solution();
            var res = sol.CanIWin(maxChoosableInteger, desiredTotal);

            //Assert
            Assert.IsFalse(res);
        }

    }
}

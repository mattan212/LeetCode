using System;
using System.Linq;
using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class FreedomTrailTests
    {
        [TestMethod]
        public void Test1()
        {
            //Arrange
            var dial = "abcdef";
            var key = "af";
            var expected = 3;

            //Act
            var sol = new FreedomTrail.Solution();
            var res = sol.FindRotateSteps(dial, key);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            var dial = "godding";
            var key = "gd";
            var expected = 4;

            //Act
            var sol = new FreedomTrail.Solution();
            var res = sol.FindRotateSteps(dial, key);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            var dial = "goodingxxixxxd";
            var key = "gdid";
            var expected = 9;

            //Act
            var sol = new FreedomTrail.Solution();
            var res = sol.FindRotateSteps(dial, key);
            
            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            var dial = "caotmcaataijjxi";
            var key = "oatjiioicitatajtijciocjcaaxaaatmctxamacaamjjx";
            var expected = 137;

            //Act
            var sol = new FreedomTrail.Solution();
            var res = sol.FindRotateSteps(dial, key);
            
            //Assert
            Assert.AreEqual(expected, res);

        }
    }
}

using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class KnightsDialerTests
    {
        private KnightsDialer.Solution _sol = new KnightsDialer.Solution();

        [TestMethod]
        public void Test1()
        {
            //Arrange
            int n = 1;
            int expected = 10;

            //Act
            var res = _sol.KnightDialer(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            // 16, 18, 27, 29, 34, 38, 43, 49, 40, 67, 61, 60, 72, 76, 81, 83, 94, 92, 04, 06
            //Arrange
            int n = 2;
            int expected = 20;

            //Act
            var res = _sol.KnightDialer(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            int n = 3;
            int expected = 46;

            //Act
            var res = _sol.KnightDialer(n);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            int n = 161;
            int expected = 533302150;

            //Act
            var res = _sol.KnightDialer(n);

            //Assert
            Assert.AreEqual(expected, res);

        }
    }
}

using LeetCodeProjects.Contributions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class AreAnagramsTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var s1 = "abcd";
            var s2 = "dcba";
            var expected = true;

            //Act
            var solver = new AreAnagrams();
            var res = solver.Solution(s1, s2);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var s1 = "Listen";
            var s2 = "Silent";
            var expected = true;

            //Act
            var solver = new AreAnagrams();
            var res = solver.Solution(s1, s2);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var s1 = "System";
            var s2 = "Sister";
            var expected = false;

            //Act
            var solver = new AreAnagrams();
            var res = solver.Solution(s1, s2);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var s1 = "Mister";
            var s2 = "Mystery";
            var expected = false;

            //Act
            var solver = new AreAnagrams();
            var res = solver.Solution(s1, s2);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var s1 = "AbCd";
            var s2 = "DcBa";
            var expected = true;

            //Act
            var solver = new AreAnagrams();
            var res = solver.Solution(s1, s2);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

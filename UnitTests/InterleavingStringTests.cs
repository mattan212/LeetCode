using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class InterleavingStringTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var s1 = "aabd";
            var s2 = "abdc";
            var s3 = "aabdbadc";
            var expected = false;

            //Act
            var solver = new InterleavingString.Solution();
            var res = solver.IsInterleave(s1, s2, s3);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}
using System.Linq;
using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class NextPermutationTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[3] {1, 3, 2};
            var expected = new int[3] {2, 1, 3};

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = new int[3] { 1, 5, 1 };
            var expected = new int[3] { 5, 1, 1 };

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var input = new int[3] { 1, 0, 2 };
            var expected = new int[3] { 1, 2, 0 };

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var input = new int[9] { 0, 4, 1, 2, 2, 1, 1, 0, 4 };
            var expected = new int[9] { 0, 4, 1, 2, 2, 1, 1, 4, 0 };

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            //Arrange
            var input = new int[4] { 1, 2, 1, 5 };
            var expected = new int[4] { 1, 2, 5, 1 };

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }

        [TestMethod]
        public void MyTestMethod6()
        {
            //Arrange
            var input = new int[3] { 3, 2, 1 };
            var expected = new int[3] { 1, 2, 3 };

            //Act
            var solver = new NextPermutation.Solution();
            solver.NextPermutation(input);

            //Assert
            Assert.AreEqual(expected.Aggregate("", (c, n) => c + n + ""), input.Aggregate("", (c, n) => c + n + ""));
        }
    }
}

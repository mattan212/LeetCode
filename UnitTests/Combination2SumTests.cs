using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems31_40;
using LeetCodeProjects.Problems41_50;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class CombinationSum2Tests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new[] { 10, 1, 2, 7, 6, 1, 5 };
            var target = 8;
            var expected = new List<List<int>>
            {
                new List<int> {1,7},
                new List<int> {1,2,5},
                new List<int> {2,6},
                new List<int> {1,1,6}
            };

            //Act
            var solver = new CombinationSum2.Solution();
            var res = solver.CombinationSum2(input, target);

            //Assert
            Assert.AreEqual(expected.Count, res.Count);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = new[] { 2, 5, 2, 1, 2 };
            var target = 5;
            var expected = new List<List<int>>
            {
                new List<int> {1,2,2},
                new List<int> {5}
            };

            //Act
            var solver = new CombinationSum2.Solution();
            var res = solver.CombinationSum2(input, target);

            //Assert
            Assert.AreEqual(expected.Count, res.Count);
        }
    }
}

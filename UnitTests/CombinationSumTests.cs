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
    public class CombinationSumTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new[] {2, 3, 6, 7};
            var target = 7;
            var expected = new List<List<int>>
            {
                new List<int> {7},
                new List<int> {2, 2, 3}
            };

            //Act
            var solver = new CombinationSum.Solution();
            var res = solver.CombinationSum(input, target);

            //Assert
            Assert.AreEqual(expected.Count, res.Count);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = new[] { 2, 3, 5 };
            var target = 8;
            var expected = new List<List<int>>
            {
                new List<int> {2, 2, 2, 2},
                new List<int> {2, 3, 3 },
                new List<int> {3, 5}
            };

            //Act
            var solver = new CombinationSum.Solution();
            var res = solver.CombinationSum(input, target);

            //Assert
            Assert.AreEqual(expected.Count, res.Count);
        }
    }
}

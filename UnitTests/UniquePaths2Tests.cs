using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems61_70;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class UniquePaths2Tests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[3, 3]
            {
                {0, 0, 0},
                {0, 1, 0},
                {0, 0, 0}
            };
            var expected = 2;

            //Act
            var solver = new UniquePaths2.Solution();
            var res = solver.UniquePathsWithObstacles(input);

            //Assert
            Assert.AreEqual(expected, res);

        }
    }
}

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
    public class _3SumTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new[] { -1, 0, 1, 2, -1, -4 };
            var expected = new List<IList<int>>
            {
                new List<int> {-1, 0, 1 },
                new List<int> { -1, -1, 2 }
            };

            //Act
            var solver = new _3Sum.Solution();
            var res = solver.ThreeSum(input);

            //Assert
            Assert.AreEqual(expected.Count, res.Count);
        }
    }
}

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
    public class LargestRectangleInHistogramTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[] {2, 1, 5, 6, 2, 3, 6, 6, 7};
            var expected = 18;

            //Act
            var solver = new LargestRectangleInHistogram.Solution();
            var res = solver.LargestRectangleArea(input);

            //Assert
            Assert.AreEqual(expected, res);

        }
    }
}

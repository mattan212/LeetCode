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
    public class MinimumWindowSubstringTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input1 = "ADOBECODEBANC";
            var input2 = "ABC";
            var expected = "BANC";

            //Act
            var solver = new MinimumWindowSubstring.Solution();
            var res = solver.MinWindow(input1, input2);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

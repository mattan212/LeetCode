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
    public class GrayCodeTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var n = 3;

            //Act
            var solver = new GrayCode.Solution();
            var res = solver.GrayCode(n);

            //Assert


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems31_40;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class JumpGame2Tests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = new int[] { 2,3,1,1,4};
            var expected = 2;

            //Act
            var solver = new JumpGame2.Solution();
            var res = solver.Jump(input);

            //Assert
            Assert.AreEqual(expected, res);
        }
    }
}

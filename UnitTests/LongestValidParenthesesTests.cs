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
    public class LongestValidParenthesesTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var input = "(()";
            var expected = 2;

            //Act
            var solver = new LongestValidParentheses.Solution();
            var res = solver.LongestValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var input = ")()())";
            var expected = 4;

            //Act
            var solver = new LongestValidParentheses.Solution();
            var res = solver.LongestValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var input = ")()))(())))";
            var expected = 4;

            //Act
            var solver = new LongestValidParentheses.Solution();
            var res = solver.LongestValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var input = "()(()";
            var expected = 2;

            //Act
            var solver = new LongestValidParentheses.Solution();
            var res = solver.LongestValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            //Arrange
            var input = "(())";
            var expected = 4;

            //Act
            var solver = new LongestValidParentheses.Solution();
            var res = solver.LongestValidParentheses(input);

            //Assert
            Assert.AreEqual(expected, res);
        }



    }
}

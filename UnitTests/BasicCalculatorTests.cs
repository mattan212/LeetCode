using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Unsorted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BasicCalculatorTests
    {
        private BasicCalculator.Solution _calculator;

        [TestInitialize]
        public void Init()
        {
            _calculator = new BasicCalculator.Solution();
        }

        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = "1 + 1";
            var expected = 2;

            //Act
            var res = _calculator.Calculate(input);

            //Assert 
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var input = "3 - 2 + 5 - 1";
            var expected = 5;

            //Act
            var res = _calculator.Calculate(input);

            //Assert 
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var input = "(1+(4+5+2)-3)+(6+8)";
            var expected = 23;

            //Act
            var res = _calculator.Calculate(input);

            //Assert 
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var input = "(1+(4+5+2)-3)+(6+8)-((1+(4+5+2)-3)+(6+8))";
            var expected = 0;

            //Act
            var res = _calculator.Calculate(input);

            //Assert 
            Assert.AreEqual(expected, res);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            var input = "1";
            var expected = 1;

            //Act
            var res = _calculator.Calculate(input);

            //Assert 
            Assert.AreEqual(expected, res);
        }
    }
}

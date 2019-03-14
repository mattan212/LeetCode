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
    public class CountTheRepetitionsTests
    {
        private readonly CountTheRepetitions.Solution _solution = new CountTheRepetitions.Solution();
        private string _s1;
        private int _n1;
        private string _s2;
        private int _n2;
        private int _expected;

        [TestMethod]
        public void Test1()
        {
            //Arrange
            _s1 = "aahumeaylnlfdxfircvscxggbwkfnqduxwfnfozvsrtkjprepggxrpnrvystmwcysyycqpevikeffmznimkkasvwsrenazkycxf";
            _n1 = 1000000;
            _s2 = "aac";
            _n2 = 10;
            _expected = 200000;

            //Act
            var res = _solution.GetMaxRepetitions(_s1, _n1, _s2, _n2);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test2()
        {
            //Arrange
            _s1 = "niconiconi";
            _n1 = 99981;
            _s2 = "nico";
            _n2 = 81;
            _expected = 2468;

            //Act
            var res = _solution.GetMaxRepetitions(_s1, _n1, _s2, _n2);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test3()
        {
            //Arrange
            _s1 = "baba";
            _n1 = 11;
            _s2 = "baab";
            _n2 = 1;
            _expected = 7;

            //Act
            var res = _solution.GetMaxRepetitions(_s1, _n1, _s2, _n2);

            //Assert
            Assert.AreEqual(_expected, res);
        }

        [TestMethod]
        public void Test4()
        {
            //Arrange
            _s1 = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            _n1 = 1000000;
            _s2 = "a";
            _n2 = 1;
            _expected = 100000000;

            //Act
            var res = _solution.GetMaxRepetitions(_s1, _n1, _s2, _n2);

            //Assert
            Assert.AreEqual(_expected, res);
        }
    }
}

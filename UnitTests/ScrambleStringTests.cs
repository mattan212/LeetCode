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
    public class ScrambleStringTests
    {
        [TestMethod]
        public void MyTestMethod1()
        {
            //Arrange
            var s1 = "great";
            var s2 = "rgtae";

            //Act
            var solver = new ScrambleString.Solution();
            var res = solver.IsScramble(s1, s2);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            //Arrange
            var s1 = "abcde";
            var s2 = "caebd";

            //Act
            var solver = new ScrambleString.Solution();
            var res = solver.IsScramble(s1, s2);

            //Assert
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            //Arrange
            var s1 = "abcdefgh";
            var s2 = "ghefabcd";

            //Act
            var solver = new ScrambleString.Solution();
            var res = solver.IsScramble(s1, s2);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MyTestMethod4()
        {
            //Arrange
            var s1 = "abc";
            var s2 = "acb";

            //Act
            var solver = new ScrambleString.Solution();
            var res = solver.IsScramble(s1, s2);

            //Assert
            Assert.IsTrue(res);
        }

        [TestMethod]
        public void MyTestMethod5()
        {
            //Arrange
            var s1 = "aaccd";
            var s2 = "acaad";

            //Act
            var solver = new ScrambleString.Solution();
            var res = solver.IsScramble(s1, s2);

            //Assert
            Assert.IsFalse(res);
        }
    }
}

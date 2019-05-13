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
    public class DistinctSubsequencesTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var s = "rabbbit";
            var t = "rabbit";
            var expected = 3;

            //Act
            var sol = new DistinctSubsequences.Solution();
            var res = sol.NumDistinct(s, t);

            //Assert
            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var s = "babgbag";
            var t = "bag";
            var expected = 5;

            //Act
            var sol = new DistinctSubsequences.Solution();
            var res = sol.NumDistinct(s, t);

            //Assert
            Assert.AreEqual(expected, res);

        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var s = "daacaedaceacabbaabdccdaaeaebacddadcaeaacadbceaecddecdeedcebcdacdaebccdeebcbdeaccabcecbeeaadbccbaeccbbdaeadecabbbedceaddcdeabbcdaeadcddedddcececbeeabcbecaeadddeddccbdbcdcbceabcacddbbcedebbcaccac";
            var t = "ceadbaa";
            var expected = 8556153;

            //Act
            var sol = new DistinctSubsequences.Solution();
            var res = sol.NumDistinct(s, t);

            //Assert
            Assert.AreEqual(expected, res);

        }

        
    }
}

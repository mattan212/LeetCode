using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems131_140;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace UnitTests
{
    [TestClass]
    public class PalindromePartitioningTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var input = "aab";
            var expected = new List<List<string>>
            {
                new List<string> {"a", "a", "b"},
                new List<string> {"aa", "b"},
            };

            //Act
            var solver = new PalindromePartitioning.Solution();
            var res = solver.Partition(input);
            
            //Assert
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(res));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var input = "aabaa";
            var expected = new List<List<string>>
            {
                new List<string> {"a", "a", "b", "a", "a"},
                new List<string> {"aa", "b", "a", "a"},
                new List<string> {"aa", "b"},
            };

            //Act
            var solver = new PalindromePartitioning.Solution();
            var res = solver.Partition(input);

            //Assert
            Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(res));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Contributions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class HiringManagerTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var requiredSkills = new List<string> {"algorithms", "math", "java", "reactjs", "csharp", "aws"};
            var candidates = new Dictionary<string, List<string>>
            {
                {"alice", new List<string> {"algorithms", "math", "java"}},
                {"bob", new List<string> {"algorithms", "math", "reactjs"}},
                {"cat", new List<string> {"java", "csharp", "aws"}},
                {"drake", new List<string> {"reactjs", "csharp"}},
                {"eva", new List<string> {"csharp", "math"}},
                {"frank", new List<string> {"aws", "java"}}
            };

            //Act
            var solver = new HiringManager.Solution();
            var res = solver.FindCandidates(requiredSkills, candidates);

            //Assert
            Assert.AreEqual(2, res.Count);
            Assert.IsTrue(res.Contains("bob"));
            Assert.IsTrue(res.Contains("cat"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var requiredSkills = new List<string> { };
            var candidates = new Dictionary<string, List<string>>
            {
                {"alice", new List<string> {"algorithms", "math", "java"}},
                {"bob", new List<string> {"algorithms", "math", "reactjs"}},
                {"cat", new List<string> {"java", "csharp", "aws"}},
                {"drake", new List<string> {"reactjs", "csharp"}},
                {"eva", new List<string> {"csharp", "math"}},
                {"frank", new List<string> {"aws", "java"}}
            };

            //Act
            var solver = new HiringManager.Solution();
            var res = solver.FindCandidates(requiredSkills, candidates);

            //Assert
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var requiredSkills = new List<string> { "algorithms", "math", "java", "azure" };
            var candidates = new Dictionary<string, List<string>>
            {
                {"alice", new List<string> {"algorithms", "math", "java"}},
                {"bob", new List<string> {"algorithms", "math", "reactjs"}},
                {"cat", new List<string> {"java", "csharp", "aws"}},
                {"drake", new List<string> {"reactjs", "csharp"}},
                {"eva", new List<string> {"csharp", "math"}},
                {"frank", new List<string> {"aws", "java"}}
            };

            //Act
            var solver = new HiringManager.Solution();
            var res = solver.FindCandidates(requiredSkills, candidates);

            //Assert
            Assert.AreEqual(0, res.Count);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var requiredSkills = new List<string> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" };
            var candidates = new Dictionary<string, List<string>>
            {
                {"alice", new List<string> {"a", "b", "c"}},
                {"bob", new List<string> {"a", "b", "d"}},
                {"cat", new List<string> {"b", "c"}},
                {"drake", new List<string> {"c", "d", "e" }},
                {"eva", new List<string> {"h", "i"}},
                {"frank", new List<string> {"g", "i"}},
                {"george", new List<string> { "i", "j", "k"}},
                {"harriett", new List<string> {"e", "f", "g" }},
                {"ivan", new List<string> {"e", "j", "k" }}
            };

            //Act
            var solver = new HiringManager.Solution();
            var res = solver.FindCandidates(requiredSkills, candidates);

            //Assert
            Assert.AreEqual(5, res.Count);
        }
    }
}

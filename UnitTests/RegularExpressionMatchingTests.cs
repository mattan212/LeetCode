using LeetCodeProjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class RegularExpressionMatchingTests
    {
        RegularExpressionMatching.Solution _solver;
        string _s;
        string _pattern;

        [TestInitialize]
        public void Init()
        {
            _solver = new RegularExpressionMatching.Solution();
        }

        [TestMethod]
        public void Test1()
        {
            _s = "aa";
            _pattern = "a";

            var res = _solver.IsMatch(_s, _pattern);

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test2()
        {
            _s = "aab";
            _pattern = "c*a*b";

            var res = _solver.IsMatch(_s, _pattern);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test3()
        {
            _s = "mississippi";
            _pattern = "mis*is*p*.";

            var res = _solver.IsMatch(_s, _pattern);

            Assert.IsFalse(res);
        }

        [TestMethod]
        public void Test4()
        {
            _s = "aa";
            _pattern = "a*";

            var res = _solver.IsMatch(_s, _pattern);

            Assert.IsTrue(res);
        }

        [TestMethod]
        public void Test5()
        {
            _s = "ab";
            _pattern = ".*";

            var res = _solver.IsMatch(_s, _pattern);

            Assert.IsTrue(res);
        }
    }
}

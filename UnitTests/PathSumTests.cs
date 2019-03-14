using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects;
using LeetCodeProjects.LeetModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class PathSumTests
    {
        [TestMethod]
        public void Test1()
        {
            var tree = new TreeNode(5)
            {
                left = new TreeNode(4)
                {
                    left = new TreeNode(11)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(2)
                    }
                },
                right = new TreeNode(8)
                {
                    left = new TreeNode(13),
                    right = new TreeNode(4)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(1)
                    }
                }
            };

            //Act
            var solver = new PathSum2.Solution();
            var res = solver.PathSum(tree, 22);

            //Assert
            Assert.AreEqual(2, res.Count);
        }

        [TestMethod]
        public void Test2()
        {
            var tree = new TreeNode(-2)
            {
                right = new TreeNode(-3)
            };

            //Act
            var solver = new PathSum2.Solution();
            var res = solver.PathSum(tree, -5);

            //Assert
            Assert.AreEqual(1, res.Count);
        }
    }
}

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
    public class PathSum3Tests
    {
        [TestMethod]
        public void Test1()
        {
            //     10
            //    /  \
            //   5 - 3
            //  / \    \
            // 3   2   11
          //  / \   \
          // 3 - 2   1
            //[10,5,-3,3,2,null,11,3,-2,null,1]
            //8
            var tree = new TreeNode(10)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(3)
                    {
                        left = new TreeNode(3),
                        right = new TreeNode(-2),
                    },
                    right = new TreeNode(2)
                    {
                        right = new TreeNode(1)
                    }
                },
                right = new TreeNode(-3)
                {
                    right = new TreeNode(11)
                }
            };

            //Act
            var sol = new PathSum3.Solution();
            var res = sol.PathSum(tree, 8);

            //Assert
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test2()
        {
           //   5 
          //   / 
          //  3   
          // / \  
          //3 - 2   

            var tree = new TreeNode(5)
            {
                left = new TreeNode(3)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(-2),
                }
            };

            //Act
            var sol = new PathSum3.Solution();
            var res = sol.PathSum(tree, 8);

            //Assert
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void Test3()
        {
            //[5,4,8,11,null,13,4,7,2,null,null,5,1]
            //22
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
                    left = new TreeNode(13)
                    {
                        left = new TreeNode(5),
                        right = new TreeNode(1)
                    },
                    right = new TreeNode(4)
                }
            };

            //Act
            var sol = new PathSum3.Solution();
            var res = sol.PathSum(tree, 22);

            //Assert
            Assert.AreEqual(3, res);
        }

        
        [TestMethod]
        public void Test4()
        {
            //[1,-2,-3,1,3,-2,null,-1]
            //-2
            var tree = new TreeNode(1)
            {
                left = new TreeNode(-2)
                {
                    left = new TreeNode(1)
                    {
                        left = new TreeNode(-1)
                    },
                    right = new TreeNode(3)
                },
                right = new TreeNode(-3)
                {
                    left = new TreeNode(-2)
                }
            };

            //Act
            var sol = new PathSum3.Solution();
            var res = sol.PathSum(tree, -2);

            //Assert
            Assert.AreEqual(4, res);
        }
    }
}

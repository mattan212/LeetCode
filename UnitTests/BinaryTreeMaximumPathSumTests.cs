using System;
using LeetCodeProjects;
using LeetCodeProjects.LeetModels;
using LeetCodeProjects.Unsorted;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class BinaryTreeMaximumPathSumTests
    {
        [TestMethod]
        public void Test1()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };

            //act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //assert
            Assert.AreEqual(6, res);
        }

        [TestMethod]
        public void Test2()
        {
            //[-10,9,20,null,null,15,7]
            //42
            var tree = new TreeNode(-10)
            {
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };

            //act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //assert
            Assert.AreEqual(42, res);
        }

        [TestMethod]
        public void Test3()
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
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //Assert
            Assert.AreEqual(29, res);
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
            };

            //Act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //Assert
            Assert.AreEqual(3, res);
        }

        [TestMethod]
        public void Test5()
        {
            //[-3]
            //-3
            var tree = new TreeNode(-3);

            //Act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //Assert
            Assert.AreEqual(-3, res);
        }

        [TestMethod]
        public void Test6()
        {
            //null
            //0
            TreeNode tree = null;

            //Act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //Assert
            Assert.AreEqual(0, res);
        }

        [TestMethod]
        public void Test7()
        {
            //[9,6,-3,null,null,-6,2,null,null,2,null,-6,-6,-6]
            //16
            var tree = new TreeNode(9)
            {
                left = new TreeNode(6),
                right = new TreeNode(-3)
                {
                    left = new TreeNode(-6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(2)
                        {
                            left = new TreeNode(-6)
                            {
                                left = new TreeNode(-6),
                            },
                            right = new TreeNode(-6)
                        }
                    }
                }
            };

            //Act
            var sol = new BinaryTreeMaximumPathSum.Solution();
            var res = sol.MaxPathSum(tree);

            //Assert
            Assert.AreEqual(16, res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.Problems101_110;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class ConstructBinaryTreeFromPreorderAndInorderTraversalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            var preorder = new int[]{3, 9, 20, 4, 5, 15, 7};
            var inorder = new int[]{4, 9, 5, 3, 15, 20, 7};

            //Act
            var solver = new ConstructBinaryTreeFromPreorderAndInorderTraversal.Solution();
            var res = solver.BuildTree(preorder, inorder);

            //Assert
        }

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            var preorder = new int[] { 1,3,2,4 };
            var inorder = new int[] { 1,2,3,4 };

            //Act
            var solver = new ConstructBinaryTreeFromPreorderAndInorderTraversal.Solution();
            var res = solver.BuildTree(preorder, inorder);

            //Assert
        }

        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            var preorder = new int[] { 1, 2 };
            var inorder = new int[] { 2, 1 };

            //Act
            var solver = new ConstructBinaryTreeFromPreorderAndInorderTraversal.Solution();
            var res = solver.BuildTree(preorder, inorder);

            //Assert
        }

        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            var preorder = new int[] { 7, -10, -4, 3, -1, 2, -8, 11 };
            var inorder = new int[] { -4, -10, 3, -1, 7, 11, -8, 2 };

            //Act
            var solver = new ConstructBinaryTreeFromPreorderAndInorderTraversal.Solution();
            var res = solver.BuildTree(preorder, inorder);

            //Assert
        }
    }
}

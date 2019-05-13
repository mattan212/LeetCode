using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems101_110
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
    /// </summary>
    public class ConstructBinaryTreeFromPreorderAndInorderTraversal
    {
        public class Solution
        {
            private int _preOrderIndex = 0;
            public TreeNode BuildTree(int[] preorder, int[] inorder)
            {
                if (preorder == null || !preorder.Any())
                {
                    return null;
                }

                return BuildTree(preorder, inorder, 0, inorder.Length - 1);
            }

            private TreeNode BuildTree(int[] preorder, int[] inorder, int start, int end)
            {
                if (start > end || _preOrderIndex >= preorder.Length)
                {
                    return null;
                }
                
                if (start == end)
                {
                    _preOrderIndex++;
                    return new TreeNode(inorder[start]);
                }

                var i = start;
                for (; i < end; i++)
                {
                    if (inorder[i] == preorder[_preOrderIndex])
                    {
                        break;
                    }
                }

                var res = new TreeNode(preorder[_preOrderIndex++]);

                if (i == start)
                {
                    res.right = BuildTree(preorder, inorder, i + 1, end);
                }
                else if (i == end)
                {
                    res.left = BuildTree(preorder, inorder, start, end - 1);
                }
                else
                {
                    res.left = BuildTree(preorder, inorder, start, i - 1);
                    res.right = BuildTree(preorder, inorder, i + 1, end);
                }

                return res;
            }
        }
    }
}

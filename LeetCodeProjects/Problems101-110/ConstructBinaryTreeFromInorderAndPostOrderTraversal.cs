using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems101_110
{
    /// <summary>
    /// https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/
    /// </summary>
    public class ConstructBinaryTreeFromInorderAndPostOrderTraversal
    {
        public class Solution
        {
            private int _postOrderIndex;
            public TreeNode BuildTree(int[] inorder, int[] postorder)
            {
                if (postorder == null || !postorder.Any())
                {
                    return null;
                }

                _postOrderIndex = postorder.Length - 1;

                return BuildTree(inorder, postorder, 0, inorder.Length - 1);
            }

            private TreeNode BuildTree(int[] inorder, int[] postorder, int start, int end)
            {
                if (start > end || _postOrderIndex < 0)
                {
                    return null;
                }
                
                if (start == end)
                {
                    _postOrderIndex--;
                    return new TreeNode(inorder[start]);
                }

                var i = start;
                for (; i < end; i++)
                {
                    if (inorder[i] == postorder[_postOrderIndex])
                    {
                        break;
                    }
                }

                var res = new TreeNode(postorder[_postOrderIndex--]);

                if (i == start)
                {
                    res.right = BuildTree(inorder, postorder, i + 1, end);
                }
                else if (i == end)
                {
                    res.left = BuildTree(inorder, postorder, start, end - 1);
                }
                else
                {
                    res.right = BuildTree(inorder, postorder, i + 1, end);
                    res.left = BuildTree(inorder, postorder, start, i - 1);
                }

                return res;
            }
        }
    }
}

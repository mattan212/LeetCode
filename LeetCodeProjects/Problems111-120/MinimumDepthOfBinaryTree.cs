using System;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-depth-of-binary-tree/
    /// </summary>
    public class MinimumDepthOfBinaryTree
    {
        public class Solution
        {
            public int MinDepth(TreeNode root)
            {
                return root != null ? MinDepth(root, 1) : 0;
            }

            private int MinDepth(TreeNode tree, int depth)
            {
                if (tree == null)
                {
                    return int.MaxValue;
                }

                if (tree.left == null && tree.right == null)
                {
                    return depth;
                }

                return Math.Min(MinDepth(tree.left, depth + 1), MinDepth(tree.right, depth + 1));
            }
        }
    }
}

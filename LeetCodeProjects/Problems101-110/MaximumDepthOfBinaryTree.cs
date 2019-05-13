using System;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-depth-of-binary-tree/
    /// </summary>
    public class MaximumDepthOfBinaryTree
    {
        public class Solution
        {
            public int MaxDepth(TreeNode root)
            {
                return MaxDepth(root, 0);
            }

            private int MaxDepth(TreeNode root, int count)
            {
                if (root == null)
                {
                    return count;
                }

                return Math.Max(MaxDepth(root.left, count + 1), MaxDepth(root.right, count + 1));
            }
        }
    }
}

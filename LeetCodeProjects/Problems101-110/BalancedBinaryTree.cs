using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/balanced-binary-tree/
    /// </summary>
    public class BalancedBinaryTree
    {
        public class Solution
        {
            private Dictionary<TreeNode, int> _mem = new Dictionary<TreeNode, int>();

            public bool IsBalanced(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }
                CalculateDepth(root, 0);

                var tree = _mem.Keys.FirstOrDefault(x => (x.left != null && x.right != null && Math.Abs(_mem[x.left] - _mem[x.right]) > 1) ||
                                                         x.left == null && _mem[x] >= 2 || x.right == null && _mem[x] >= 2);

                return tree == null;
            }

            private void CalculateDepth(TreeNode tree, int depth)
            {
                var maxDepth = 0;
                if (tree.left != null)
                {
                    CalculateDepth(tree.left, depth + 1);
                    maxDepth = _mem[tree.left] + 1;
                }

                if (tree.right != null)
                {
                    CalculateDepth(tree.right, depth + 1);
                    maxDepth = Math.Max(maxDepth, _mem[tree.right] + 1);
                }

                _mem.Add(tree, maxDepth);
            }
        }
    }
}

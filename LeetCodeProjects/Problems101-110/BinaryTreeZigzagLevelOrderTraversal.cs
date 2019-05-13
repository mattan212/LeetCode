using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/
    /// </summary>
    public class BinaryTreeZigzagLevelOrderTraversal
    {
        public class Solution
        {
            public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
            {
                IList<IList<int>> res = new List<IList<int>>();
                if (root == null)
                {
                    return res;
                }
                var current = new List<TreeNode>
                {
                    root
                };

                var count = 0;
                while (current.Any())
                {
                    var nums = new List<int>();
                    var next = new List<TreeNode>();
                    foreach (var tree in current)
                    {
                        nums.Add(tree.val);
                        if (tree.left != null)
                        {
                            next.Add(tree.left);
                        }

                        if (tree.right != null)
                        {
                            next.Add(tree.right);
                        }
                    }

                    if (count++ % 2 == 1)
                    {
                        nums.Reverse();
                    }
                    current = next;
                    res.Add(nums);
                }

                return res;
            }
        }
    }
}

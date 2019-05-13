using System.Collections;
using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-level-order-traversal/
    /// </summary>
    public class BinaryTreeLevelOrderTraversal
    {
        public class Solution
        {
            public IList<IList<int>> LevelOrder(TreeNode root)
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

                    current = next;
                    res.Add(nums);
                }

                return res;
            }
        }
    }
}

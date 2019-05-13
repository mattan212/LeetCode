using System.Collections.Generic;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-inorder-traversal/
    /// </summary>
    public class BinaryTreeInorderTraversal
    {
        public class Solution
        {
            public IList<int> InorderTraversal(TreeNode root)
            {
                var res = new List<int>();

                if (root == null)
                {
                    return res;
                }

                Traverse(root, res);

                return res;
            }

            private void Traverse(TreeNode tree, List<int> aggregate)
            {
                if (tree.left != null)
                {
                    Traverse(tree.left, aggregate);
                }

                aggregate.Add(tree.val);

                if (tree.right != null)
                {
                    Traverse(tree.right, aggregate);
                }
            }
        }
    }
}

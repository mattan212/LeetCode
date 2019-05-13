using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems111_120
{
    /// <summary>
    /// https://leetcode.com/problems/flatten-binary-tree-to-linked-list/
    /// </summary>
    public class FlattenBinaryTreeToLinkedList
    {
        public class Solution
        {
            public void Flatten(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }

                var list = new List<int>();

                Extract(root, list);

                root.left = null;
                root.val = list[0];
                var current = root;
                for (var i = 1; i < list.Count; i++)
                {
                    current.right = new TreeNode(list[i]);
                    current = current.right;
                }
            }

            private void Extract(TreeNode tree, List<int> list)
            {
                list.Add(tree.val);
                if (tree.left != null)
                {
                    Extract(tree.left, list);
                }
                if (tree.right != null)
                {
                    Extract(tree.right, list);
                }
            }
        }
    }
}

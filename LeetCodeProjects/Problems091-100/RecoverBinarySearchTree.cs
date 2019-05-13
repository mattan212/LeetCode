using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    public class RecoverBinarySearchTree
    {
        public class Solution
        {
            public void RecoverTree(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }

                var data = new List<int>();
                var mem = new List<TreeNode>();

                ParseTree(root, data, mem);

                data = data.OrderBy(x => x).ToList();

                for (var i = 0; i < data.Count; i++)
                {
                    mem[i].val = data[i];
                }
            }

            private void ParseTree(TreeNode tree, List<int> data, List<TreeNode> mem)
            {
                if (tree.left != null)
                {
                    ParseTree(tree.left, data, mem);
                }

                mem.Add(tree);
                data.Add(tree.val);

                if (tree.right != null)
                {
                    ParseTree(tree.right, data, mem);
                }
            }
        }
    }
}

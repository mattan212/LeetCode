using System.Collections.Generic;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    public class ValidateBinarySearchTree
    {
        public class Solution
        {
            public bool IsValidBST(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }

                var data = new List<int>();

                ParseTree(root, data);

                for (var i = 0; i < data.Count - 1; i++)
                {
                    if (data[i] >= data[i + 1])
                    {
                        return false;
                    }
                }
                    
                return true;
            }

            private void ParseTree(TreeNode tree, List<int> data)
            {
                if (tree.left != null)
                {
                    ParseTree(tree.left, data);
                }

                data.Add(tree.val);

                if (tree.right != null)
                {
                    ParseTree(tree.right, data);
                }
            }
        }
    }
}

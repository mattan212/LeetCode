using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/
    /// </summary>
    public class SymmetricTree
    {
        public class Solution
        {
            public bool IsSymmetric(TreeNode root)
            {
                if (root == null)
                {
                    return true;
                }
                
                return IsSymmetric(root.left, root.right);
            }

            private bool IsSymmetric(TreeNode left, TreeNode right)
            {
                if (left == null && right == null)
                {
                    return true;
                }

                if ((left == null && right != null) ||
                    (left != null && right == null) ||
                    (left.val != right.val))
                {
                    return false;
                }

                return IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
            }

        }
    }
}

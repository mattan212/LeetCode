using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum/description/
    /// </summary>
    public class PathSum
    {
        public class Solution
        {
            public bool HasPathSum(TreeNode root, int sum)
            {
                if (root == null)
                {
                    return false;
                }

                if (root.left == null && root.right == null)
                {
                    return root.val == sum;
                }

                return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
            }
        }
    }
}

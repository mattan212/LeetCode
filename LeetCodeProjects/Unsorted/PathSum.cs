using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Unsorted
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

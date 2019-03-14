using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/binary-tree-maximum-path-sum/description/
    /// </summary>
    public class BinaryTreeMaximumPathSum
    {
        public class Solution
        {
            private int _max = int.MinValue;
            
            private Dictionary<int, int> _memo = new Dictionary<int, int>();

            public int MaxPathSum(TreeNode root)
            {
                CalculateMaxPathSum(root);

                return _max != int.MinValue ? _max : 0;
            }

            /// <summary>
            /// Returns the max sum of only one path selection (either right or left), not including root.
            /// </summary>
            /// <param name="root"></param>
            /// <returns></returns>
            private int ChooseOnePathSum(TreeNode root)
            {
                if (root == null)
                {
                    return 0;
                }

                if (_memo.ContainsKey(root.GetHashCode()))
                {
                    return _memo[root.GetHashCode()];
                }

                if (root.left == null && root.right == null)
                {
                    return root.val;
                }

                var left = ChooseOnePathSum(root.left);

                var right = ChooseOnePathSum(root.right);

                var res = MultiMax(root.val, left + root.val, right + root.val);

                _memo[root.GetHashCode()] = res;

                return res;
            }

            private void CalculateMaxPathSum(TreeNode root)
            {
                if (root == null)
                {
                    return;
                }

                var left = ChooseOnePathSum(root.left);
                var right = ChooseOnePathSum(root.right);

                //this is the tipping point
                var max = MultiMax(root.val, root.val + left, root.val + right, root.val + left + right);

                _max = Math.Max(_max, max);

                CalculateMaxPathSum(root.left);
                CalculateMaxPathSum(root.right);
            }

            private int MultiMax(int a, int b, int c, int d = int.MinValue)
            {
                return Math.Max(Math.Max(a, b), Math.Max(c, d));
            }
        }
    }
}

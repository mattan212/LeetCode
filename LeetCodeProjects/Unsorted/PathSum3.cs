using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/path-sum-iii/description/
    /// </summary>
    public class PathSum3
    {
        public class Solution
        {
            public int PathSum(TreeNode root, int target)
            {
                int[] sums = new int[1000];

                return helper(sums, root, 1, target);
            }

            int helper(int[] sums, TreeNode node, int level, int target)
            {
                if (node == null)
                {
                    return 0;
                }

                int hit = 0;
                for (int i = 0; i < level; i++)
                {
                    sums[i] += node.val;

                    if (sums[i] == target)
                    {
                        hit += 1;
                    }
                }

                int count = hit + helper(sums, node.left, level + 1, target)
                                + helper(sums, node.right, level + 1, target);
                for (int i = 0; i < level; i++)
                {
                    sums[i] -= node.val;
                }

                return count;
            }
        }
    }
}

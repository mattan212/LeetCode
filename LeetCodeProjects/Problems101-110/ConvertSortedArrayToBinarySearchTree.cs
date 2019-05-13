using System.Collections.Generic;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/
    /// </summary>
    public class ConvertSortedArrayToBinarySearchTree
    {
        public class Solution
        {
            public TreeNode SortedArrayToBST(int[] nums)
            {
                if (nums == null || nums.Length == 0)
                {
                    return null;
                }
                int mid = nums.Length / 2;
                var root = new TreeNode(nums[mid]);
                var left = new List<int>();
                var right = new List<int>();

                for (var i = 0; i < nums.Length; i++)
                {
                    if (i == mid)
                    {
                        continue;
                    }
                    else if (i < mid)
                    {
                        left.Add(nums[i]);
                    }
                    else
                    {
                        right.Add(nums[i]);
                    }

                }

                root.left = SortedArrayToBST(left.ToArray());
                root.right = SortedArrayToBST(right.ToArray());
                return root;
            }
        }
    }
}

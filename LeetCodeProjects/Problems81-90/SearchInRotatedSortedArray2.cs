using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems81_90
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    /// </summary>
    public class SearchInRotatedSortedArray2
    {
        public class Solution
        {
            public bool Search(int[] nums, int target)
            {
                if (!nums.Any())
                {
                    return false;
                }

                if (nums.Length == 1)
                {
                    return nums[0] == target;
                }

                if (target >= nums[0])
                {
                    for (var i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                        {
                            return true;
                        }

                        if (i + 1 < nums.Length && nums[i] > nums[i + 1])
                        {
                            return false;
                        }
                    }
                }
                else
                {
                    for (var i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] == target)
                        {
                            return true;
                        }

                        if (i - 1 >= 0 && nums[i] < nums[i - 1])
                        {
                            return false;
                        }
                    }
                }

                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/search-in-rotated-sorted-array/
    /// </summary>
    public class SearchInRotatedSortedArray
    {
        public class Solution
        {
            public int Search(int[] nums, int target)
            {
                if (!nums.Any())
                {
                    return -1;
                }

                if (nums.Length == 1)
                {
                    return nums[0] == target ? 0 : -1;
                }
                
                if (target >= nums[0])
                {
                    for (var i = 0; i < nums.Length; i++)
                    {
                        if (nums[i] == target)
                        {
                            return i;
                        }

                        if (i + 1 < nums.Length && nums[i] > nums[i + 1])
                        {
                            return -1;
                        }
                    }
                }
                else
                {
                    for (var i = nums.Length - 1; i >= 0; i--)
                    {
                        if (nums[i] == target)
                        {
                            return i;
                        }

                        if (i - 1 >= 0 && nums[i] < nums[i - 1])
                        {
                            return -1;
                        }
                    }
                }

                return -1;
            }
        }
    }
}

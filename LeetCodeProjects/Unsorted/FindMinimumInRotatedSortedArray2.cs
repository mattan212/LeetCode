using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// </summary>
    public class FindMinimumInRotatedSortedArray2
    {
        public class Solution
        {
            public int FindMin(int[] nums)
            {
                var min = nums[0];

                for (var i = 1; i < nums.Length; i++)
                {
                    if (nums[i] < min)
                    {
                        min = nums[i];
                    }
                }

                return min;
            }
        }
    }
}

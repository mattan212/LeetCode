﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/find-minimum-in-rotated-sorted-array/
    /// </summary>
    public class FindMinimumInRotatedSortedArray
    {
        public class Solution
        {
            public int FindMin(int[] nums)
            {

                for (var i = 0; i < nums.Length - 1; i++)
                {
                    if (nums[i + 1] < nums[i])
                    {
                        return nums[i + 1];
                    }
                }

                return nums[0];
            }
        }
    }
}

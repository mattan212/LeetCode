using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems21_30
{
    /// <summary>
    /// https://leetcode.com/problems/remove-element/
    /// </summary>
    public class RemoveElement
    {
        public class Solution
        {
            public int RemoveElement(int[] nums, int val)
            {
                var placementIndex = 0;
                foreach (var n in nums)
                {
                    if (n != val)
                    {
                        nums[placementIndex++] = n;
                    }
                }

                return placementIndex;
            }
        }
    }
}

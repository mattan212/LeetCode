using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems31_40
{
    /// <summary>
    /// https://leetcode.com/problems/find-first-and-last-position-of-element-in-sorted-array/
    /// </summary>
    public class FindFirstAndLastPositionOfElementInSortedArray
    {
        public class Solution
        {
            int[] _badResult = new[] { -1, -1 };
            public int[] SearchRange(int[] nums, int target)
            {
                if (nums == null || !nums.Any())
                {
                    return new[] { -1, -1 };
                }

                if (nums.Length == 1)
                {
                    return nums[0] == target ? new[] { 0, 0 } : _badResult;
                }

                var end = nums.Length;
                var start = (int)end / 2;

                var indexA = -1;
                var indexB = -1;

                var last = -1;
                while (start != end)
                {
                    if (last == start)
                    {
                        break;
                    }
                    else
                    {
                        last = start;
                    }

                    if (nums[start] == target)
                    {
                        indexA = start;
                        indexB = start;
                        break;
                    }
                    else if (nums[start] < target)
                    {
                        start = (start + end) / 2;
                    }
                    else
                    {
                        end = start;
                        start = 0 + end / 2;
                    }
                }

                if (indexA == -1)
                {
                    return new[] { -1, -1 };
                }

                while (indexA > 0 && nums[indexA - 1] == target)
                {
                    indexA--;
                }

                while (indexB < nums.Length - 1 && nums[indexB + 1] == target)
                {
                    indexB++;
                }

                return new[] { indexA, indexB };
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/median-of-two-sorted-arrays/
    /// </summary>
    public class MedianOfTwoSortedArrays
    {
        public class Solution
        {
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                if (!nums1.Any() || !nums2.Any())
                {
                    return nums1.Any() ? Median(nums1) : Median(nums2);
                }

                var changeSequence = new Stack<int>();
                var index1 = 0;
                var index2 = 0;
                for (var i = 0; i <= (nums1.Length + nums2.Length) / 2; i++)
                {
                    var num1 = index1 < nums1.Length ? nums1[index1] : int.MaxValue;
                    var num2 = index2 < nums2.Length ? nums2[index2] : int.MaxValue;

                    var last = Math.Min(num1, num2);
                    if (index1 < nums1.Length && nums1[index1] == last)
                    {
                        changeSequence.Push(1);
                        index1++;
                    }
                    else
                    {
                        changeSequence.Push(2);
                        index2++;
                    }
                }

                index1--; index2--;

                double median = changeSequence.Pop() == 1 ? nums1[index1--] : nums2[index2--];
                if ((nums1.Length + nums2.Length) % 2 == 0)
                {
                    median = (median + (changeSequence.Pop() == 1 ? nums1[index1] : nums2[index2])) / 2;
                }

                return median;
            }

            private double Median(int[] nums)
            {
                double res;
                int mid = (nums.Length) / 2;
                if (nums.Length % 2 == 0)
                {
                    res = ((double)nums[mid - 1] + nums[mid]) / 2;
                }
                else
                {
                    res = nums[mid];
                }

                return res;
            }
        }
    }
}

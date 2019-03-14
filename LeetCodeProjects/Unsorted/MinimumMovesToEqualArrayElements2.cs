using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/minimum-moves-to-equal-array-elements-ii/
    /// </summary>
    public class MinimumMovesToEqualArrayElements2
    {
        public class Solution
        {
            public int MinMoves2(int[] nums)
            {
                var avg = FindMedian(nums);

                var res = 0;

                foreach (var x in nums)
                {
                    res += (int)Math.Abs(avg - x);
                }

                return res;
            }

            private int FindMedian(int[] nums)
            {
                int index = nums.Length / 2;

                return nums.OrderBy(x => x).ElementAt(index);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/maximum-gap/
    /// </summary>
    public class MaximumGap
    {
        public class Solution
        {
            public int MaximumGap(int[] nums)
            {
                if (nums.Length <= 1)
                {
                    return 0;
                }

                var list = nums.OrderBy(x => x).ToList();
                var res = 0;
                for (var i = 0; i < list.Count - 1; i++)
                {
                    if (list[i + 1] - list[i] > res)
                    {
                        res = list[i + 1] - list[i];
                    }
                }

                return res;
            }
        }
    }
}

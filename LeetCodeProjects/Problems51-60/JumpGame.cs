using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems31_40
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game/
    /// </summary>
    public class JumpGame
    {
        public class Solution
        {
            public bool Jump(int[] nums)
            {
                if (!nums.Any())
                {
                    return true;
                }

                var reach = 0;
                for (var i = 0; i <= reach; i++)
                {
                    if (i == nums.Length - 1)
                    {
                        return true;
                    }

                    reach = Math.Max(reach, i + nums[i]);
                }

                return false;
            }
        }
    }
}

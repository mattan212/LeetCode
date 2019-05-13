using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array/
    /// </summary>
    public class RemoveDuplicatesFromSortedArray
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                if (!nums.Any())
                {
                    return 0;
                }

                var placementIndex = 0;
                for (var i = 0; i < nums.Length; i++)
                {
                    if (i + 1 < nums.Length && nums[i] != nums[i + 1])
                    {
                        nums[placementIndex++] = nums[i];
                    }
                }
                nums[placementIndex++] = nums.Last();

                return placementIndex;
            }
        }
    }
}

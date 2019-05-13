using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/
    /// </summary>
    public class RemoveDuplicatesFromSortedArray2
    {
        public class Solution
        {
            public int RemoveDuplicates(int[] nums)
            {
                var dict = new Dictionary<int, int>();

                for (var i = 0; i < nums.Length; i++)
                {
                    if (!dict.ContainsKey(nums[i]))
                    {
                        dict.Add(nums[i], 1);
                    }
                    else
                    {
                        dict[nums[i]]++;
                    }
                }

                var index = 0;
                foreach (var entry in dict)
                {
                    if (entry.Value == 1)
                    {
                        nums[index] = entry.Key;
                        index++;
                    }
                    else
                    {
                        nums[index] = entry.Key;
                        nums[index + 1] = entry.Key;
                        index += 2;
                    }
                }

                return index;
            }
        }
    }
}

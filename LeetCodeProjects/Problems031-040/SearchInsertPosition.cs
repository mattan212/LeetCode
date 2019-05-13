namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/search-insert-position/
    /// </summary>
    public class SearchInsertPosition
    {
        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                int i;
                if (nums.Length == 0 || target < nums[0])
                {
                    return 0;
                }

                for (i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == target)
                    {
                        return i;
                    }
                    else if (i + 1 < nums.Length && (nums[i] < target && nums[i + 1] > target))
                    {
                        return i + 1;
                    }
                }

                return i;
            }
        }
    }
}

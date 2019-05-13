namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/sort-colors/
    /// </summary>
    public class SortColors
    {
        public class Solution
        {
            public void SortColors(int[] nums)
            {
                var i = 0;
                var mem = new int[3];
                for (i = 0; i < nums.Length; i++)
                {
                    mem[nums[i]]++;
                }

                for (i = 0; i < mem[0]; i++)
                {
                    nums[i] = 0;
                }

                var offset = i;
                for (; i < mem[1] + offset; i++)
                {
                    nums[i] = 1;
                }

                offset = i;
                for (; i < mem[2] + offset; i++)
                {
                    nums[i] = 2;
                }
            }
        }

    }
}

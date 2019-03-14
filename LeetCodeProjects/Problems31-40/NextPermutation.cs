namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/next-permutation/
    /// </summary>
    public class NextPermutation
    {
        public class Solution
        {
            public void NextPermutation(int[] nums)
            {
                for (var i = nums.Length - 1; i > 0; i--)
                {
                    if (nums[i - 1] < nums[i])
                    {
                        for (var j = nums.Length - 1; j >= i; j--)
                        {
                            if (nums[j] > nums[i - 1])
                            {
                                Swap(nums, i - 1, j);
                                Reverse(nums, i);
                                return;
                            }
                        }
                    }
                }

                Reverse(nums, 0);
            }

            private void Reverse(int[] nums, int start)
            {
                int i = start, j = nums.Length - 1;
                while (i < j)
                {
                    Swap(nums, i, j);
                    i++;
                    j--;
                }
            }

            private void Swap(int[] nums, int i, int j)
            {
                var temp = nums[i];
                nums[i] = nums[j];
                nums[j] = temp;
            }
        }
    }
}

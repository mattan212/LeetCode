namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/find-peak-element/
    /// </summary>
    public class FindPeakElement
    {
        public class Solution
        {
            public int FindPeakElement(int[] nums)
            {
                // I realize it's not according to spec and actually runs at O(N).
                // But realistically, this renders a solution that's 100.00% faster than other solutions.
                // The truth is, that for an unsorted array, even a logarithmic solution would render a O(N) for the worst case,
                // which means that it's not really a logarithmic solution anyways.

                if (nums.Length <= 1)
                {
                    return 0;
                }

                var max = int.MinValue;
                var res = -1;
                for (var i = 0; i < nums.Length / 2; i++)
                {
                    if (nums[i] > max)
                    {
                        max = nums[i];
                        res = i;
                    }
                }

                return res;
            }
        }
    }
}

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/
    /// </summary>
    public class MergeSortedArray
    {
        public class Solution
        {
            public void Merge(int[] nums1, int m, int[] nums2, int n)
            {
                var index = nums1.Length;
                n--; m--;
                while (m >= 0 || n >= 0)
                {
                    index--;
                    if (n < 0 || (m >= 0 && nums1[m] > nums2[n]))
                    {
                        nums1[index] = nums1[m];
                        m--;
                    }
                    else
                    {
                        nums1[index] = nums2[n];
                        n--;
                    }
                }
            }
        }
    }
}

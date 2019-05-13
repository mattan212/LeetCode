namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/
    /// </summary>
    public class PlusOne
    {
        public class Solution
        {
            public int[] PlusOne(int[] digits)
            {
                var carry = 0;
                for (var i = digits.Length - 1; i >= 0; i--)
                {
                    digits[i] += 1;
                    if (digits[i] > 9)
                    {
                        if (i == 0)
                        {
                            digits = new int[digits.Length + 1];
                            digits[0] = 1;
                            break;
                        }
                        digits[i] = 0;

                    }
                    else
                    {
                        break;
                    }
                }

                return digits;
            }
        }
    }
}

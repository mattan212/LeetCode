using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber
    {
        public class Solution
        {

            public bool IsPalindrome(int x)
            {
                if (x < 0)
                {
                    return false;
                }
                if (x < 10)
                {
                    return true;
                }

                var reversed = 0;
                var tmp = x;
                while (tmp > 0)
                {
                    reversed = (reversed * 10) + (tmp % 10);
                    tmp /= 10;
                }

                return reversed == x;
            }
        }
    }
}

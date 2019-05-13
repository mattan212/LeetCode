using System;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/length-of-last-word/
    /// </summary>
    public class LengthOfLastWord
    {
        public class Solution
        {
            public int LengthOfLastWord(string s)
            {
                var split = s.Split(new[]{' '}, StringSplitOptions.RemoveEmptyEntries);

                return split.Any() ? split.Last().Length : 0;
            }
        }
    }
}

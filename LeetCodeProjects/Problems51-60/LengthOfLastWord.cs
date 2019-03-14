using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems51_60
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

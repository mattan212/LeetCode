using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems21_30
{
    /// <summary>
    /// https://leetcode.com/problems/generate-parentheses/
    /// </summary>
    public class GenerateParentheses
    {
        public class Solution
        {
            public IList<string> GenerateParenthesis(int n)
            {
                var res = new List<string>();
                if (n == 0)
                {
                    res.Add("");
                    return res;
                }

                for (int i = 0; i < n; i++)
                {
                    foreach (var left in GenerateParenthesis(i))
                    {
                        foreach (var right in GenerateParenthesis(n - i - 1))
                        {
                            res.Add("(" + left + ")" + right);
                        }
                    }
                }

                return res;
            }
        }
    }
}

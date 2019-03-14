using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems31_40
{
    /// <summary>
    /// https://leetcode.com/problems/count-and-say/
    /// </summary>
    public class CountAndSay
    {
        public class Solution
        {
            public string CountAndSay(int n)
            {
                var res = "1";
                for (int i = 1; i < n; i++)
                {
                    res = Count(res);
                }
                return res;
            }

            private string Count(string s)
            {
                var res = "";
                char c = s[0];
                int count = 1;
                for (int i = 1; i < s.Length; i++)
                {
                    if (s[i] == c)
                    {
                        count++;
                    }
                    else
                    {
                        res += count;
                        res += c;
                        c = s[i];
                        count = 1;
                    }
                }

                res += count;
                res += c;
                return res;
            }
        }
    }
}

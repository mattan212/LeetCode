using System;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/number-complement/submissions/
    /// </summary>
    public class NumberComplement
    {
        public class Solution
        {
            public int FindComplement(int num)
            {
                if (num == 0)
                {
                    return 1;
                }

                var s = "";
                while (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        s = "1" + s;
                    }
                    else
                    {
                        s = "0" + s;
                    }
                    num /= 2;
                }

                var res = 0;

                for (var i = s.Length - 1; i >= 0; i--)
                {
                    if (s[i] == '1')
                    {
                        res += (int)Math.Pow(2, s.Length - i - 1);
                    }
                }

                return res;
            }
        }
    }
}

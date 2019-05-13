using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/string-to-integer-atoi/
    /// </summary>
    public class StringToIntegerATOI
    {
        public class Solution
        {
            public int MyAtoi(string str)
            {
                str = str.TrimStart(' ');
                var first = (int)'0';
                var last = (int)'9';
                var dash = (int)'-';

                var res = 0;
                if (str.Length == 0 || str.Length == 1 && str[0] < '0' || str.Length == 1 && str[0] > '9')
                {
                    return 0;
                }

                var pre = 1;
                if (str[0] == '-')
                {
                    pre = -1;
                    str = str.Substring(1);
                }
                else if (str[0] == '+')
                {
                    str = str.Substring(1);
                }

                for (var i = 0; i < str.Length; i++)
                {
                    var c = str[i];
                    if (c < '0' || c > '9')
                    {
                        break;
                    }

                    if (res > int.MaxValue / 10 || (res == int.MaxValue / 10 && c - first >= 7 && pre > 0) ||
                        (res == int.MaxValue / 10 && c - first >= 8 && pre < 0))
                    {
                        return pre > 0 ? int.MaxValue : -1 * int.MaxValue - 1;
                    }

                    res *= 10;
                    res += c - first;
                }

                return res * pre;
            }
        }
    }
}

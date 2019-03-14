using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems41_50
{
    /// <summary>
    /// https://leetcode.com/problems/multiply-strings/
    /// </summary>
    public class MultiplyStrings
    {
        public class Solution
        {
            public string Multiply(string num1, string num2)
            {
                if (num1 == "0" || num2 == "0")
                {
                    return "0";
                }

                var container = new string[110];
                var zeros = "";
                for (var i = 0; i < num1.Length; i++)
                {
                    var multi = Multiply(num1[num1.Length - 1 - i], num2) + zeros;
                    zeros += '0';
                    container[i] = multi;
                }

                var res = "0";
                for (var i = 0; i < container.Length && container[i] != null; i++)
                {
                    res = AddStrings(res, container[i]);
                }

                return res;
            }

            private string Multiply(char c, string num)
            {
                int carry = 0;
                var res = "";
                for (var i = num.Length - 1; i >= 0; i--)
                {
                    var multi = (c - '0') * (num[i] - '0') + carry;
                    if (multi >= 10)
                    {
                        carry = multi / 10;
                        multi %= 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    res = multi + res;
                }

                return (carry + res).TrimStart('0');
            }

            private string AddStrings(string num1, string num2)
            {
                int carry = 0;
                var max = Math.Max(num1.Length, num2.Length);
                num1 = num1.PadLeft(max, '0');
                num2 = num2.PadLeft(max, '0');

                var res = "";
                for (var i = max - 1; i >= 0; i--)
                {
                    var current = num1[i] - '0' + num2[i] - '0' + carry;
                    if (current >= 10)
                    {
                        carry = current / 10;
                        current %= 10;
                    }
                    else
                    {
                        carry = 0;
                    }
                    res = current + res;
                }

                return (carry + res).TrimStart('0');
            }
        }
    }
}

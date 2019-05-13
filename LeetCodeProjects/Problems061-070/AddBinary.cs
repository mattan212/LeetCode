using System;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/
    /// </summary>
    public class AddBinary
    {
        public class Solution
        {
            public string AddBinary(string a, string b)
            {
                var length = Math.Max(a.Length, b.Length);
                a = a.PadLeft(length, '0');
                b = b.PadLeft(length, '0');
                var res = "";
                var carry = false;
                for (var i = length - 1; i >= 0; i--)
                {
                    var c = (a[i] - '1' + 1) + (b[i] - '1' + 1) + (carry ? 1 : 0);
                    carry = c >= 2;
                    res = ((c == 1 || c == 3) ? '1' : '0') + res;
                }

                return (carry) ? '1' + res : res;
            }
        }
    }
}

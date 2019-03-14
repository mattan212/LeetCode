using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems11_20
{
    /// <summary>
    /// https://leetcode.com/problems/letter-combinations-of-a-phone-number/
    /// </summary>
    public class LetterCombinationsOfPhoneNumber
    {
        public class Solution
        {
            public IList<string> LetterCombinations(string digits)
            {
                var res = new List<string>();

                if (digits == "")
                {
                    return res;
                }

                var first = digits[0];
                var current = _dict[first];

                if (digits.Length == 1)
                {
                    return current;
                }

                digits = digits.Substring(1);

                var next = LetterCombinations(digits);

                foreach (var s1 in current)
                {
                    foreach (var s2 in next)
                    {
                        res.Add(s1 + s2);
                    }
                }

                return res;
            }

            private Dictionary<char, List<string>> _dict = new Dictionary<char, List<string>> {
                { '0', new List<string>() },
                { '1', new List<string>() },
                { '2', new List<string>{ "a", "b", "c"} },
                { '3', new List<string>{ "d", "e", "f"} },
                { '4', new List<string>{ "g", "h", "i"} },
                { '5', new List<string>{ "j", "k", "l"} },
                { '6', new List<string>{ "m", "n", "o"} },
                { '7', new List<string>{ "p", "q", "r", "s"} },
                { '8', new List<string>{ "t", "u", "v"}},
                { '9', new List<string>{ "w", "x", "y", "z"} },
            };
        }
    }
}

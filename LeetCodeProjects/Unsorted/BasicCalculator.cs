using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/basic-calculator/
    /// </summary>
    public class BasicCalculator
    {
        public class Solution
        {
            private Dictionary<int, int> _paranMap;

            public int Calculate(string s)
            {
                InitParanMap(s);

                return Calculate(s, 0, s.Length);
            }

            private int Calculate(string s, int start, int end)
            {
                var res = 0;
                var lastOp = '+';
                for (var i = start; i < end; i++)
                {
                    var current = s[i];
                    if (current >= '0' && current <= '9' || current == '(')
                    {
                        var num = current == '(' ? 
                            EvalParans(s, i, out i) : 
                            GetNum(s, i, out i);
                        res = lastOp == '+' ? res + num : res - num;
                    }
                    else if (current == ' ')
                    {
                        // whitespace
                    }
                    else
                    {
                        lastOp = s[i];
                    }
                }

                return res;
            }

            // Populate the paranMap with the index of the closers
            private void InitParanMap(string s)
            {
                _paranMap = new Dictionary<int, int>();
                var stack = new Stack<int>();
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        stack.Push(i);
                    }
                    else if (s[i] == ')')
                    {
                        var openIndex = stack.Pop();
                        _paranMap.Add(openIndex, i);
                    }
                }
            }

            private int GetNum(string s, int index, out int resumeIndex)
            {
                var num = 0;
                while (index < s.Length && s[index] >= '0' && s[index] <= '9')
                {
                    num = num * 10 + (s[index++] - '0');
                }
                resumeIndex = index - 1;
                return num;
            }

            private int EvalParans(string s, int index, out int resumeIndex)
            {
                var paranEnd = _paranMap[index];
                resumeIndex = paranEnd;
                var res = Calculate(s, index + 1, paranEnd);
                return res;
            }
        }
    }
}

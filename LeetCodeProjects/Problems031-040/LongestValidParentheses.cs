using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    public class LongestValidParentheses
    {
        public class Solution
        {
            public int LongestValidParentheses(string s)
            {
                var openersStack = new Stack<int>();
                var validsDict = new Dictionary<int, Tuple<int, int>>();
                var max = 0;
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == '(')
                    {
                        openersStack.Push(i);
                    }
                    else if (openersStack.Any())
                    {
                        var opener = openersStack.Pop();
                        var tuple = validsDict.ContainsKey(opener - 1)
                            ? new Tuple<int, int>(validsDict[opener - 1].Item1, i)
                            : new Tuple<int, int>(opener, i);
                        validsDict.Add(i, tuple);

                        max = Math.Max(max, tuple.Item2 - tuple.Item1 + 1);
                    }
                }

                return max;
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/valid-parentheses/
    /// </summary>
    public class ValidParentheses
    {
        public class Solution
        {
            public bool IsValid(string s)
            {
                if (s.Length % 2 != 0)
                {
                    return false;
                }
                var stack = new Stack<char>();
                for (var i = 0; i < s.Length; i++)
                {
                    if (s[i] == ')' && stack.Any())
                    {
                        var last = stack.Pop();
                        if (last != '(')
                        {
                            return false;
                        }
                    }
                    else if (s[i] == ']' && stack.Any())
                    {
                        var last = stack.Pop();
                        if (last != '[')
                        {
                            return false;
                        }
                    }
                    else if (s[i] == '}' && stack.Any())
                    {
                        var last = stack.Pop();
                        if (last != '{')
                        {
                            return false;
                        }
                    }
                    else if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                    {
                        stack.Push(s[i]);
                    }
                    else
                    {
                        return false;
                    }
                }

                return !stack.Any();
            }
        }

    }
}

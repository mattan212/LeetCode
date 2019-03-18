using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems71_80
{
    /// <summary>
    /// https://leetcode.com/problems/simplify-path/
    /// </summary>
    public class SimplifyPath
    {
        public class Solution
        {
            public string SimplifyPath(string path)
            {
                var split = path.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                var res = "/";
                if (!split.Any())
                {
                    return res;
                }
                var stack = new Stack<string>();
                foreach (var s in split)
                {
                    if (s == "..")
                    {
                        if (stack.Any())
                        {
                            stack.Pop();
                        }

                    }
                    else if (s != ".")
                    {
                        stack.Push(s + "/");
                    }
                }

                while (stack.Any())
                {
                    res = stack.Pop() + res;
                }

                return "/" + res.TrimEnd('/');
            }
        }
    }
}

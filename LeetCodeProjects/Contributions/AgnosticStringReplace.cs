using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Contributions
{
    public class AgnosticStringReplace
    {
        public class Solution
        {
            public string Replace(string s, string source, string target)
            {
                var lower = s.ToLower();
                source = source.ToLower();
                var res = new StringBuilder();

                for (var i = 0; i < s.Length; i++)
                {
                    var areMatch = s.Length >= i + source.Length;
                    for (var j = 0; j < source.Length && areMatch; j++)
                    {
                        if (lower[i + j] != source[j])
                        {
                            areMatch = false;
                        }
                    }

                    if (areMatch)
                    {
                        res.Append(target);
                        i += source.Length - 1;
                    }
                    else
                    {
                        res.Append(s[i]);
                    }
                }

                return res.ToString();
            }
        }
    }
}

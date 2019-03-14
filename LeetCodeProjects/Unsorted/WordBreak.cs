using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/word-break/description/
    /// </summary>
    public class WordBreak
    {
        public class Solution
        {
            private HashSet<string> _falseMem = new HashSet<string>();

            public bool WordBreak(string s, IList<string> wordDict)
            {
                if (s == "")
                {
                    return true;
                }

                if (_falseMem.Contains(s))
                {
                    return false;
                }

                var options = wordDict.Where(s.StartsWith).ToList();

                if (!options.Any())
                {
                    _falseMem.Add(s);

                    return false;
                }

                foreach (var option in options)
                {
                    var res = WordBreak(s.Substring(option.Length), wordDict);
                    if (res)
                    {
                        return true;
                    }
                }

                _falseMem.Add(s);

                return false;
            }
        }
    }
}

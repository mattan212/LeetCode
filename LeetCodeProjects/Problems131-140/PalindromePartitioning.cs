using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems131_140
{
    public class PalindromePartitioning
    {
        public class Solution
        {
            public IList<IList<string>> Partition(string s)
            {
                var res = new List<IList<string>>();

                if (string.IsNullOrEmpty(s))
                {
                    return res;
                }

                Helper(s, 0, res);

                return res;
            }
            
            private void Helper(string s, int startIndex, IList<IList<string>> res)
            {
                for (var i = startIndex + 1; i <= s.Length; i++)
                {
                    if (IsPalindrome(s, startIndex, i))
                    {
                        var current = Partition(s.Substring(i));
                        var sub = s.Substring(startIndex, i - startIndex);
                        if (current.Any())
                        {
                            foreach (var list in current)
                            {
                                list.Insert(0, sub);
                                res.Add(list);
                            }
                        }
                        else
                        {
                            res.Add(new List<string> { sub });
                        }

                    }
                }
            }
            
            private bool IsPalindrome(string s, int start, int end)
            {
                var res = true;
                end--;
                
                while (start < end)
                {
                    if (s[start++] != s[end--])
                    {
                        res = false;
                        break;
                    }
                }
                return res;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems41_50
{
    /// <summary>
    /// https://leetcode.com/problems/group-anagrams/
    /// </summary>
    public class GroupAnagrams
    {
        public class Solution
        {
            public IList<IList<string>> GroupAnagrams(string[] strs)
            {
                var dict = new Dictionary<string, IList<string>>();

                foreach (var str in strs)
                {
                    var sorted = SortString(str);
                    if (!dict.ContainsKey(sorted))
                    {
                        dict.Add(sorted, new List<string>());
                    }
                    dict[sorted].Add(str);
                }

                return dict.Values.ToList();
            }

            private string SortString(string str)
            {
                var chars = str.OrderBy(x => x).ToArray();
                return new String(chars);
            }
        }
    }
}

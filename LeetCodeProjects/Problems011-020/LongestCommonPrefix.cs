using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/longest-common-prefix/
    /// </summary>
    public class LongestCommonPrefix
    {
        public class Solution
        {
            public string LongestCommonPrefix(string[] strs)
            {
                if (!strs.Any())
                {
                    return "";
                }
                var res = "";
                
                for (var i = 0; i < strs.First().Length; i++)
                {
                    var current = strs[0][i];
                    if (strs.All(x => i < x.Length && x[i] == current))
                    {
                        res += current;
                    }
                    else
                    {
                        break;
                    }
                }

                return res;
            }
        }
    }
}

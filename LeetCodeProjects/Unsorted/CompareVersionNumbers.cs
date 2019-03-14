using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/compare-version-numbers/
    /// </summary>
    public class CompareVersionNumbers
    {
        public class Solution
        {
            public int CompareVersion(string version1, string version2)
            {
                var split1 = version1.Split('.');
                var split2 = version2.Split('.');

                for (var i = 0; i < Math.Max(split1.Length, split2.Length); i++)
                {
                    var current1 = i < split1.Length ? int.Parse(split1[i]) : 0;
                    var current2 = i < split2.Length ? int.Parse(split2[i]) : 0;

                    if (current1 > current2)
                    {
                        return 1;
                    }
                    if (current1 < current2)
                    {
                        return -1;
                    }
                }

                return 0;
            }
        }
    }
}

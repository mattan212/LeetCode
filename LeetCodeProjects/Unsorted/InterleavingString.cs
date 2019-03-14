using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/interleaving-string/description/
    /// </summary>
    public class InterleavingString
    {
        public class Container
        {
            public string S1 { get; set; }
            public string S2 { get; set; }
            public string S3 { get; set; }

            public Container(string s1, string s2, string s3)
            {
                S1 = s1;
                S2 = s2;
                S3 = s3;
            }

            public override bool Equals(object obj)
            {
                var other = (Container)obj;
                return other.S1 == S1 && other.S2 == S2 && other.S3 == S3;
            }
        }
        public class Solution
        {
            private Dictionary<Container, bool> _dict = new Dictionary<Container, bool>();

            public bool IsInterleave(string s1, string s2, string s3)
            {
                var res = false;
                var container = new Container(s1, s2, s3);

                if (_dict.ContainsKey(container))
                {
                    return _dict[container];
                }

                if (s1 == "" && s2 == "" && s3 == "")
                {
                    res = true;
                }
                else if (s3 == "" && (s1 != "" || s2 != ""))
                {
                    res = false;
                }
                else if (s1 != "" && s2 != "" && s1[0] == s2[0] && s1[0] == s3[0])
                {
                    res = IsInterleave(s1.Length > 1 ? s1.Substring(1) : "", s2, s3.Length > 1 ? s3.Substring(1) : "") ||
                              IsInterleave(s1, s2.Length > 1 ? s2.Substring(1) : "", s3.Length > 1 ? s3.Substring(1) : "");
                }
                else if (s1 != "" && s1[0] == s3[0])
                {
                    res = IsInterleave(s1.Length > 1 ? s1.Substring(1) : "", s2, s3.Length > 1 ? s3.Substring(1) : "");
                }
                else if (s2 != "" && s2[0] == s3[0])
                {
                    res = IsInterleave(s1, s2.Length > 1 ? s2.Substring(1) : "", s3.Length > 1 ? s3.Substring(1) : "");
                }

                _dict.Add(container, res);

                return res;
            }
        }
    }
}

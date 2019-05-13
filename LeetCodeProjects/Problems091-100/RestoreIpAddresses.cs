using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCodeProjects
{
    public class RestoreIpAddresses
    {
        public class Solution
        {
            public IList<string> RestoreIpAddresses(string s)
            {
                var res = new List<string>();
                for (var i = 1; i <= 3 && i < s.Length; i++)
                {
                    for (var j = i + 2; j < i + 5 && j < s.Length + 1; j++)
                    {
                        for (var k = j + 2; k < j + 5 && k < s.Length + 2 && s.Length - k <= 3; k++)
                        {
                            var sb = new StringBuilder(s, s.Length + 4);
                            sb.Insert(i, '.').Insert(j, '.').Insert(k, '.');
                            if (IsValidIp(sb.ToString()))
                            {
                                res.Add(sb.ToString());
                            }
                        }
                    }
                }
                return res;
            }

            private bool IsValidIp(string ipAttempt)
            {
                var split = ipAttempt.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                return split.Length == 4 && (!split.Any(x => (x.Length > 1 && x[0] == '0')) &&
                                             !split.Select(x => int.Parse(x)).Any(x => x < 0 || x > 255));
            }
        }
    }
}

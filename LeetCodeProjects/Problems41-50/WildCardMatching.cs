using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems41_50
{
    /// <summary>
    /// https://leetcode.com/problems/wildcard-matching/
    /// </summary>
    public class WildCardMatching
    {
        public class Solution
        {
            public bool IsMatch(string s, string p)
            {
                if (!p.Contains('*'))
                {
                    return Match(s, p);
                }

                var split = p.Split('*').Where(x => x.Length > 0).ToArray();

                if (split.Length == 0)
                {
                    return p.StartsWith("*") || s.Length == 0;
                }

                var min = -1;
                for (var i = 0; i < split.Length; i++)
                {
                    var indices = FindIndices(s, split[i]);
                    if (!indices.Any())
                    {
                        return false;
                    }

                    int current;
                    try
                    {
                        current = indices.First(x => x >= min);
                    }
                    catch
                    {
                        return false;
                    }

                    if (!p.StartsWith("*") && min == -1 && current > 0)
                    {
                        return false;
                    }

                    min = current + split[i].Length - i.ToString().Length;
                }

                var last = split[split.Length - 1];

                return p.EndsWith("*") || Match(s.Substring(s.Length - last.Length), last);
            }

            private bool Match(string s, string p)
            {
                if (p.Length > s.Length)
                {
                    return false;
                }

                for (var i = 0; i < s.Length; i++)
                {
                    if (i >= p.Length)
                    {
                        return false;
                    }

                    if (p[i] != '?' && p[i] != s[i])
                    {
                        return false;
                    }
                }

                return true;
            }

            private List<int> FindIndices(string s, string p)
            {
                var res = new List<int>();
                for (int i = 0; i < s.Length + 1 - p.Length; i++)
                {
                    if (Match(s.Substring(i, p.Length), p))
                    {
                        res.Add(i);
                    }
                }

                return res;
            }
        }
    }
}

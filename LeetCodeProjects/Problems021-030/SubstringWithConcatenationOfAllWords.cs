using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// 
    /// </summary>
    public class SubstringWithConcatenationOfAllWords
    {
        public class Solution
        {
            public IList<int> FindSubstring(string s, string[] words)
            {
                var res = new List<int>();
                var length = words.Sum(t => t.Length);
                if (s == "" || !words.Any() || s.Length < length)
                {
                    return res;
                }

                var sum = words.Aggregate(0, (a, b) => a + b.Aggregate(0, (x, y) => x + y));

                var sumDict = GetSumsDict(s, length);

                for (var i = 0; i < s.Length - length + 1; i++)
                {
                    if (sumDict[i] == sum && IsPermutation(s, words, i, i + length))
                    {
                        res.Add(i);
                    }
                }
                return res;
            }

            private Dictionary<int, int> GetSumsDict(string s, int length)
            {
                var res = new Dictionary<int, int>();
                var sum = 0;
                for (var i = 0; i < length; i++)
                {
                    sum += s[i];
                }

                res.Add(0, sum);
                for (var i = 1; i < s.Length - length + 1; i++)
                {
                    sum = sum + s[i + length - 1] - s[i - 1];
                    res.Add(i, sum);
                }
                return res;
            }

            private bool IsPermutation(string s, string[] words, int start, int end)
            {
                var used = Enumerable.Repeat(false, words.Length).ToArray();
                var sIndex = start;
                while (sIndex < end)
                {
                    var found = false;
                    for (var i = 0; i < words.Length; i++)
                    {
                        if (!used[i] && s.Substring(sIndex, words[i].Length) == words[i])
                        {
                            used[i] = true;
                            sIndex += words[i].Length;
                            found = true;
                        }
                    }

                    if (!found)
                    {
                        return false;
                    }
                }
                return true;
            }

        }
    }
}

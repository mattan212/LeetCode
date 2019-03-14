using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems51_60
{
    /// <summary>
    /// https://leetcode.com/problems/text-justification/
    /// </summary>
    public class TextJustification
    {
        public class Solution
        {
            public IList<string> FullJustify(string[] words, int maxWidth)
            {
                var res = new List<string>();

                var current = "";
                foreach (var word in words)
                {
                    if ((current + " " + word).Length > maxWidth)
                    {
                        if (current != "")
                        {
                            res.Add(current);
                        }
                        current = word;
                    }
                    else
                    {
                        current = (current + " " + word).Trim(' ');
                    }
                }

                res.Add(current);

                for (var i = 0; i < res.Count - 1; i++)
                {
                    var size = res[i].Replace(" ", "").Length;
                    var split = res[i].Split(' ');
                    res[i] = "";
                    var rotatingIndex = 0;
                    for (var j = size; j < maxWidth; j++)
                    {
                        if (rotatingIndex >= split.Length - 1)
                        {
                            rotatingIndex = 0;
                        }
                        split[rotatingIndex] += " ";
                        rotatingIndex++;
                    }
                    res[i] = split.Aggregate("", (current1, s) => current1 + s);
                }

                res[res.Count - 1] = res[res.Count - 1].PadRight(maxWidth, ' ');

                return res;
            }
        }
    }
}

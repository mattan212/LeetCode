using System;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/count-the-repetitions/description/
    /// </summary>
    public class CountTheRepetitions
    {
        public class Solution
        {
            public int GetMaxRepetitions(string s1, int n1, string s2, int n2)
            {
                s1 = CleanString(s1, s2);

                if (s1 == s2)
                {
                    return n1 / n2;
                }

                if (n2 > n1 && s1.Length <= s2.Length)
                {
                    return 0;
                }

                var denominator = CommonDenominator(n1, n2);
                n1 /= denominator;
                n2 /= denominator;

                var res = FullMatchCount(s1, s2) * n1 / n2;

                var temp = s1.Replace(s2, "");

                if (temp == "" || s2.Any(x => !temp.Contains(x)))
                {
                    return res;
                }
                else
                {
                    res = 0;
                }

                var index = 0;
                for (var i = 0; i < s1.Length * n1; i++)
                {
                    if (s1[i % s1.Length] == s2[index % s2.Length])
                    {
                        index++;
                    }

                    if (index >= s2.Length * n2)
                    {
                        res++;
                        index = 0;
                    }
                }
                
                return res;
            }
            
            private int FullMatchCount(string s1, string s2)
            {
                var originalLength = s1.Length;

                s1 = s1.Replace(s2, "");

                return (originalLength - s1.Length) / s2.Length;
            }

            private int CommonDenominator(int n1, int n2)
            {
                if (n1 % n2 == 0)
                {
                    return n2;
                }

                var div = (int)Math.Sqrt(n2);

                while (div > 1)
                {
                    if (n2 % div == 0 && n1 % div == 0)
                    {
                        return div;
                    }

                    div--;
                }

                return div;
            }

            private string CleanString(string s1, string s2)
            {
                var toRemove = s1.Except(s2);
                foreach (var c in toRemove)
                {
                    s1 = s1.Replace("" + c, "");
                }

                return s1;
            }
        }
    }
}

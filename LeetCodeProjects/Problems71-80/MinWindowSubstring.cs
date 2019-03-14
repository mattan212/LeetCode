using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects
{
    /// <summary>
    /// Solution for question 76: https://leetcode.com/problems/minimum-window-substring/description/#
    /// </summary>
    public class MinWindowSubstring
    {        
        public class Solution
        {
            private int[] _tArr;
            private List<char> _tChars;

            private int[] ToCounterArray(string s)
            {
                var arr = new int[256];
                foreach (var c in s)
                {
                    arr[c]++;
                }
                return arr;
            }

            private bool IsContained(int[] sArr)
            {
                foreach (var c in _tChars)
                {
                    if (sArr[c] < _tArr[c])
                    {
                        return false;
                    }
                }

                return true;
            }

            public string MinWindow(string s, string t)
            {
                if (s == t)
                {
                    return s;
                }

                if (t.Length > s.Length)
                {
                    return "";
                }

                _tArr = ToCounterArray(t);
                _tChars = t.ToList();

                var winner = s + "$";
                var sArr = new int[256];

                int a = 0;
                int b = 0;

                var currentIndex = -1;
                var currentLength = int.MaxValue;

                while (b < s.Length)
                {
                    var lastChanged = s[b];
                    sArr[s[b]]++;
                    b++;

                    if (_tArr[lastChanged] == 0 || _tArr[lastChanged] > sArr[lastChanged])
                    {
                        continue;
                    }

                    if (b - a >= t.Length && IsContained(sArr))
                    {
                        //var current = s.Substring(a, b - a);
                        if (b - a < currentLength)
                        {
                            currentIndex = a;
                            currentLength = b - a;
                        }
                        
                        //if (current.Length < winner.Length)
                        //{
                        //    winner = current;
                        //}

                        while (true)
                        {
                            if (b - a < currentLength)
                            {
                                currentIndex = a;
                                currentLength = b - a;
                            }

                            sArr[s[a]]--;

                            if (_tArr[s[a]] > sArr[s[a]])
                            {
                                a++;
                                break;
                            }

                            a++;
                        }
                    }
                }

                return currentIndex == -1 ? "" : s.Substring(currentIndex, currentLength);
            }
        }
    }
}

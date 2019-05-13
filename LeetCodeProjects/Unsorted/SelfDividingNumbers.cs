using System.Collections.Generic;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/self-dividing-numbers/
    /// </summary>
    public class SelfDividingNumbers
    {
        public class Solution
        {
            public IList<int> SelfDividingNumbers(int left, int right)
            {
                var res = new List<int>();
                for (var i = left; i <= right; i++)
                {
                    if (IsSelfDividing(i))
                    {
                        res.Add(i);
                    }
                }

                return res;
            }

            private bool IsSelfDividing(int num)
            {
                var temp = num;
                while (temp > 0)
                {
                    var current = temp % 10;
                    if (current == 0)
                    {
                        return false;
                    }

                    if (num % current != 0)
                    {
                        return false;
                    }

                    temp /= 10;
                }
                return true;
            }
        }
    }
}

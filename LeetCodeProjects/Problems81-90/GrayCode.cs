using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProjects.Problems81_90
{
    /// <summary>
    /// https://leetcode.com/problems/gray-code/
    /// </summary>
    public class GrayCode
    {
        public class Solution
        {
            public IList<int> GrayCode(int n)
            {
                var max = (int) (Math.Pow(2, n));

                var map = new List<List<int>>();

                for (var i = 0; i < max; i++)
                {
                    var options = GetAccessList(i, n);
                    map.Add(options);
                }

                var res = new List<int>{ 0 };

                var visited = Enumerable.Repeat(false, max).ToArray();
                visited[0] = true;
                FindPath(map, visited, 0, res);

                return res;
            }

            private void FindPath(List<List<int>> map, bool[] visited, int current, List<int> aggregate)
            {
                foreach (var option in map[current].Where(x => !visited[x]))
                {
                    visited[option] = true;
                    aggregate.Add(option);

                    FindPath(map, visited, option, aggregate);

                    if (aggregate.Count == visited.Length)
                    {
                        return;
                    }

                    visited[option] = false;
                    aggregate.RemoveAt(aggregate.Count - 1);
                }
            }

            private List<int> GetAccessList(int num, int bitsCount)
            {
                var res = new List<int>();

                var usedBits = new bool[bitsCount];
                var index = 0;
                while (num > 0)
                {
                    if (num % 2 == 1)
                    {
                        usedBits[index] = true;
                    }

                    index++;
                    num /= 2;
                }

                for (var i = 0; i < bitsCount; i++)
                {
                    usedBits[i] = !usedBits[i];
                    var current = 0;
                    for (var j = 0; j < bitsCount; j++)
                    {
                        if (usedBits[j])
                        {
                            current += (int)Math.Pow(2, j);
                        }
                    }
                    res.Add(current);
                    usedBits[i] = !usedBits[i];
                }

                return res;
            }
        }
    }
}

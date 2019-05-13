using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/jump-game-ii/
    /// </summary>
    public class JumpGame2
    {
        public class Solution
        {
            public int Jump(int[] nums)
            {
                if (!nums.Any())
                {
                    return 0;
                }
                var visited = new bool[nums.Length];
                var vertices = new Stack<int>();
                vertices.Push(0);
                var current = 0;
                while (vertices.Any())
                {
                    var next = new Stack<int>();
                    while (vertices.Any())
                    {
                        var v = vertices.Pop();
                        if (v == nums.Length - 1)
                        {
                            return current;
                        }

                        visited[v] = true;
                        for (var i = 0; i < nums[v]; i++)
                        {
                            if (v + i + 1 < nums.Length && !visited[v + i + 1])
                            {
                                next.Push(v + i + 1);
                            }
                        }
                    }

                    current++;
                    
                    vertices = next;
                }
                
                return -1;
            }
        }
    }
}

using System.Collections.Generic;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-image/
    /// </summary>
    public class RotateImage
    {
        public class Solution
        {
            public void Rotate(int[,] matrix)
            {
                var length = matrix.GetLength(0);
                var queue = new Queue<int>();
                for (var i = 0; i < length; i++)
                {
                    for (var j = 0; j < length; j++)
                    {
                        queue.Enqueue(matrix[i, j]);
                    }
                }

                for (var i = 0; i < length; i++)
                {
                    for (var j = 0; j < length; j++)
                    {
                        matrix[j, length - i - 1] = queue.Dequeue();
                    }
                }
            } 
        }
    }
}

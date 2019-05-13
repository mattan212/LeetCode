using System;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/generate-random-point-in-a-circle/submissions/
    /// DOESN'T PASS ALL TESTS
    /// </summary>
    public class GenerateRandomPointInACircle
    {
        public class Solution
        {
            private Random _rand;
            private double _radius;
            private double _xCenter;
            private double _yCenter;

            public Solution(double radius, double x_center, double y_center)
            {
                _rand = new Random();
                _radius = radius;
                _xCenter = x_center;
                _yCenter = y_center;
            }

            public double[] RandPoint()
            {
                var angle = _rand.Next(360) + 1;

                var dist = _radius * _rand.NextDouble();

                var x = Math.Sin(angle) * dist;
                var y = Math.Cos(angle) * dist;

                return new double[2]
                {
                    _xCenter + x, _yCenter + y
                };
            }
        }
    }
}

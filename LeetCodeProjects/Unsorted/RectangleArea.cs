using System;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/rectangle-area/description/
    /// </summary>
    public class RectangleArea
    {
        public class Solution
        {
            public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
            {
                var rect1 = new Rectangle(A, B, C, D);
                var rect2 = new Rectangle(E, F, G, H);
                var common = GetCommonRectangle(rect1, rect2);

                return rect1.Area + rect2.Area - common.Area;
            }

            private Rectangle GetCommonRectangle(Rectangle rect1, Rectangle rect2)
            {
                if (((rect2.BottomLeft.Item1 >= rect1.TopRight.Item1) ||
                    (rect2.TopRight.Item1 <= rect1.BottomLeft.Item1)) ||
                    (rect2.TopRight.Item2 <= rect1.BottomLeft.Item2) ||
                    (rect2.BottomLeft.Item2 >= rect1.TopRight.Item2)
                    )
                {
                    return new Rectangle(0, 0, 0, 0);
                }

                var rect = new Rectangle(
                    Math.Max(rect1.BottomLeft.Item1, rect2.BottomLeft.Item1),
                    Math.Max(rect1.BottomLeft.Item2, rect2.BottomLeft.Item2),
                    Math.Min(rect1.TopRight.Item1, rect2.TopRight.Item1),
                    Math.Min(rect1.TopRight.Item2, rect2.TopRight.Item2));

                return rect;
            }
        }

        public class Rectangle
        {
            public Tuple<int, int> BottomLeft { get; }

            public Tuple<int, int> TopRight { get; }

            public Rectangle(int bottomLeftX, int bottomLeftY, int topRightX, int topRightY)
            {
                BottomLeft = new Tuple<int, int>(bottomLeftX, bottomLeftY);
                TopRight = new Tuple<int, int>(topRightX, topRightY);
            }

            public int Area
            {
                get { return ((TopRight.Item1 - BottomLeft.Item1) * (TopRight.Item2 - BottomLeft.Item2)); }
            }
        }
    }

    //A = -3, B = 0, C = 3, D = 4, E = 0, F = -1, G = 9, H = 2
    // (-3,0), (3,4). (0, -1) (9, 2)
    // Max bottom left x => 0.
    // Max bottom left y => 0.
    // Min Top right x => 3
    // Min Top right y => 2
    // common area = 6.
    // sol = 6 * 4 + 9 * 3 - 6 = 24 + 27 - 6 = 45.
}

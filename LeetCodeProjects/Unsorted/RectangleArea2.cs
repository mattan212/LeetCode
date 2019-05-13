using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/rectangle-area/description/
    /// </summary>
    public class RectangleArea2
    {
        public class Solution
        {
            public int RectangleArea(int[][] rectangles)
            {
                int OPEN = 0, CLOSE = 1;
                List<int[]> events = new List<int[]>();
                
                foreach (var rec in rectangles)
                {
                    events.Add(new int[] { rec[1], OPEN, rec[0], rec[2] });
                    events.Add(new int[] { rec[3], CLOSE, rec[0], rec[2] });
                }

                events = events.OrderBy(x => x[0]).ToList();

                var active = new List<int[]>();
                int curY = events[0][0];
                long ans = 0;
                foreach (var ev in events) {
                    int y = ev[0], typ = ev[1], x1 = ev[2], x2 = ev[3];

                    // Calculate query
                    long query = 0;
                    int cur = -1;
                    foreach (var xs in active) {
                        cur = Math.Max(cur, xs[0]);
                        query += Math.Max(xs[1] - cur, 0);
                        cur = Math.Max(cur, xs[1]);
                    }

                    ans += query* (y - curY);

                    if (typ == OPEN)
                    {
                        active.Add(new int[]{x1, x2});
                        active = active.OrderBy(x => x[0]).ToList();
                    }
                    else
                    {
                        for (int i = 0; i < active.Count; ++i)
                            if (active.ElementAt(i)[0] == x1 && active.ElementAt(i)[1] == x2)
                            {
                                active.RemoveAt(i);
                                break;
                            }
                    }

                    curY = y;
                }

                ans %= 1_000_000_007;
                return (int) ans;
            }
            //public int RectangleArea(int[][] rectangles)
            //{
            //    var rects = rectangles.Select(rect => new Rectangle(rect[0], rect[1], rect[2], rect[3])).ToList();

            //    long res = 0;

            //    for (var subset = 1; subset < (1 << rects.Count); subset++)
            //    {
            //        var rect = new Rectangle(0, 0, 1000000000, 1000000000);

            //        var parity = -1;

            //        for (var bit = 0; bit < rects.Count; bit++)
            //        {
            //            if (((subset >> bit) & 1) != 0)
            //            {
            //                rect = GetCommonRectangle(rect, rects[bit]);
            //                parity *= -1;
            //            }
            //        }

            //        res += parity * rect.Area;
            //    }

            //    long MOD = 1_000_000_007;
            //    res %= MOD;
            //    if (res < 0)
            //    {
            //        res += MOD;
            //    }

            //    return (int)res;
            //    //return (int) (res % (Math.Pow(10, 9) + 7));
            //}

            //public int RectangleArea(int[][] rectangles)
            //{
            //    var rects = rectangles.Select(rect => new Rectangle(rect[0], rect[1], rect[2], rect[3])).ToList();
                
            //    var res = RectangleAreaFull(rects);

            //    return (int) (res % (Math.Pow(10, 9) + 7));
            //}

            //private long RectangleAreaFull(List<Rectangle> rectangles)
            //{
            //    if (!rectangles.Any())
            //    {
            //        return 0;
            //    }

            //    var rects = new List<Rectangle>();

            //    var conflicts = new List<Rectangle>();

            //    long reduce = 0;
            //    foreach (var rect in rectangles)
            //    {
            //        foreach (var prev in rects)
            //        {
            //            var common = GetCommonRectangle(prev, rect);

            //            if (common.Area > 0)
            //            {
            //                if (conflicts.Any(x => x.Equals(common)))
            //                {
            //                    conflicts.First(x => x.Equals(common)).Count++;
            //                }
            //                else
            //                {
            //                    conflicts.Add(common);
            //                }
            //            }
            //        }

            //        rects.Add(rect);
            //    }
                
            //    reduce += RectangleAreaFull(conflicts);

            //    long res = 0;
            //    foreach (var rect in rects)
            //    {
            //        res += rect.Area * (rect.Count + 1);
            //    }

            //    return res - reduce;
            //}

            //private Rectangle GetCommonRectangle(Rectangle rect1, Rectangle rect2)
            //{
            //    if (((rect2.BottomLeft.Item1 >= rect1.TopRight.Item1) ||
            //        (rect2.TopRight.Item1 <= rect1.BottomLeft.Item1)) ||
            //        (rect2.TopRight.Item2 <= rect1.BottomLeft.Item2) ||
            //        (rect2.BottomLeft.Item2 >= rect1.TopRight.Item2)
            //        )
            //    {
            //        return new Rectangle(0, 0, 0, 0);
            //    }

            //    var rect = new Rectangle(
            //        Math.Max(rect1.BottomLeft.Item1, rect2.BottomLeft.Item1),
            //        Math.Max(rect1.BottomLeft.Item2, rect2.BottomLeft.Item2),
            //        Math.Min(rect1.TopRight.Item1, rect2.TopRight.Item1),
            //        Math.Min(rect1.TopRight.Item2, rect2.TopRight.Item2));

            //    return rect;
            //}
        }

        public class Rectangle
        {
            public Tuple<int, int> BottomLeft { get; }

            public Tuple<int, int> TopLeft { get; }

            public Tuple<int, int> BottomRight { get; }
            
            public Tuple<int, int> TopRight { get; }

            public Rectangle(int bottomLeftX, int bottomLeftY, int topRightX, int topRightY)
            {
                BottomLeft = new Tuple<int, int>(bottomLeftX, bottomLeftY);
                TopLeft = new Tuple<int, int>(bottomLeftX, topRightY);
                BottomRight = new Tuple<int, int>(topRightX, bottomLeftY);
                TopRight = new Tuple<int, int>(topRightX, topRightY);
            }

            public List<Tuple<int, int>> GetCoordinates()
            {
                var res = new List<Tuple<int, int>>
                {
                    BottomLeft,
                    BottomRight,
                    TopLeft,
                    TopRight
                };

                return res;
            }

            public long Area
            {
                get
                {
                    long x = TopRight.Item1 - BottomLeft.Item1;
                    long y = TopRight.Item2 - BottomLeft.Item2;

                    return x * y % 1000000007;
                }
            }

            public int Count { get; set; }

            public override bool Equals(object obj)
            {
                var res = false;
                var asRect = obj as Rectangle;
                if (asRect != null)
                {
                    res = asRect.BottomLeft.Item1 == this.BottomLeft.Item1 &&
                          asRect.BottomLeft.Item2 == this.BottomLeft.Item2 &&
                          asRect.TopRight.Item1 == this.TopRight.Item1 &&
                          asRect.TopRight.Item2 == this.TopRight.Item2;
                }

                return res;
            }

            public IEnumerable<Rectangle> Union(Rectangle rectangle)
            {
                var res = new List<Rectangle>();

                // No common space
                if ((rectangle.BottomLeft.Item1 >= this.TopRight.Item1) ||
                    (rectangle.BottomLeft.Item2 >= this.TopRight.Item2) ||
                    (this.BottomLeft.Item1 >= rectangle.TopRight.Item1) ||
                    (this.BottomLeft.Item2 >= rectangle.TopRight.Item2))
                {
                    res.Add(rectangle);
                    res.Add(this);
                }
                // rectangle is containing this
                else if ((rectangle.BottomLeft.Item1 <= this.BottomLeft.Item1) &&
                    (rectangle.BottomLeft.Item2 <= this.BottomLeft.Item2) &&
                    (rectangle.TopRight.Item1 >= this.TopRight.Item1) &&
                    (rectangle.TopRight.Item2 <= this.TopRight.Item2))
                {
                    res.Add(rectangle);
                    return res;
                }

                // this containing rectangle
                else if ((this.BottomLeft.Item1 <= rectangle.BottomLeft.Item1) &&
                    (this.BottomLeft.Item2 <= rectangle.BottomLeft.Item2) &&
                    (this.TopRight.Item1 >= rectangle.TopRight.Item1) &&
                    (this.TopRight.Item2 <= rectangle.TopRight.Item2))
                {
                    res.Add(rectangle);
                    return res;
                }
                // partial common ground
                else
                {
                    var xs = new List<Tuple<int, int>>
                    {
                        rectangle.BottomLeft, rectangle.TopRight, this.BottomLeft, this.TopRight
                    }.OrderBy(x => x.Item1).ToList();

                    var first = rectangle.BottomLeft.Item1 < this.BottomLeft.Item1 ? rectangle : this;
                    var second = rectangle.BottomLeft.Item1 < this.BottomLeft.Item1 ? this: rectangle;

                    var y1 = first.TopRight.Item2;
                    var y2 = second.BottomLeft.Item2;
                    
                    var rect1 = new Rectangle(xs[0].Item1, xs[0].Item2, xs[1].Item1, y1);
                    var rect2 = new Rectangle(xs[1].Item1, Math.Min(rectangle.BottomLeft.Item2, this.BottomLeft.Item2), xs[2].Item1, Math.Max(rectangle.TopRight.Item2, this.TopRight.Item2));
                    var rect3 = new Rectangle(xs[2].Item1, y2, xs[3].Item1, xs[3].Item2);

                    res.Add(rect1);
                    res.Add(rect2);
                    res.Add(rect3);
                }

                return res;


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

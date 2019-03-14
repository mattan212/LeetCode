using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems51_60
{
    /// <summary>
    /// https://leetcode.com/problems/insert-interval/
    /// </summary>
    public class InsertInterval
    {
        public class Solution
        {
            public IList<Interval> Insert(IList<Interval> intervals, Interval newInterval)
            {
                var a = intervals.FirstOrDefault(x => x.start <= newInterval.start && x.end >= newInterval.start);
                var b = intervals.FirstOrDefault(x => x.start <= newInterval.end && x.end >= newInterval.end);

                if ((a == null && b == null) || (a == b))
                {
                    a = intervals.FirstOrDefault(x => x.start <= newInterval.start && x.end >= newInterval.end);
                    if (a == null)
                    {
                        intervals = intervals.Where(x => x.end < newInterval.start || x.start > newInterval.end).ToList();
                        intervals.Add(newInterval);
                    }
                }
                else if (a != null && b == null)
                {
                    newInterval.start = a.start;
                    intervals = intervals.Where(x => x.end < newInterval.start || x.start > newInterval.end).ToList();
                    intervals.Add(newInterval);

                }
                else if (a == null)
                {
                    newInterval.end = b.end;
                    intervals = intervals.Where(x => x.end < newInterval.start || x.start > newInterval.end).ToList();
                    intervals.Add(newInterval);
                }
                else
                {
                    if (a == b)
                    {
                        intervals = intervals.ToList();
                        intervals.Remove(a);
                        intervals.Add(newInterval);
                    }
                    else
                    {
                        newInterval.start = a.start;
                        newInterval.end = b.end;
                        intervals = intervals.Where(x => x.end < newInterval.start || x.start > newInterval.end).ToList();
                        intervals.Add(newInterval);
                    }
                }

                return intervals.OrderBy(x => x.start).ToList();
            }
        }
    }
}

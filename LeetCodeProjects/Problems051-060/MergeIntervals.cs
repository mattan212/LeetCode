using System;
using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/merge-intervals/
    /// </summary>
    public class MergeIntervals
    {
        public class Solution
        {
            public IList<Interval> Merge(IList<Interval> intervals)
            {

                intervals = intervals.OrderBy(x => x.start).ToList();
                var index = 0;
                while (index < intervals.Count - 1)
                {
                    if (intervals[index + 1].start <= intervals[index].end)
                    {
                        intervals[index].end = Math.Max(intervals[index].end, intervals[index + 1].end);
                        intervals.RemoveAt(index + 1);
                    }
                    else
                    {
                        index++;
                    }
                }

                return intervals;
            }
        }
    }
}

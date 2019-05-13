using System.Collections.Generic;
using System.Linq;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/merge-k-sorted-lists/
    /// </summary>
    public class MergeKSortedLists
    {
        public class Solution
        {
            public ListNode MergeKLists(ListNode[] lists)
            {
                var list = new List<int>();

                var asList = lists.Where(x => x != null).ToList();

                while (asList.Any())
                {
                    var first = asList[0];
                    while (first != null)
                    {
                        list.Add(first.val);
                        first = first.next;
                    }
                    asList.RemoveAt(0);
                }

                if (list.Any())
                {
                    list = list.OrderBy(x => x).ToList();
                    var root = new ListNode(0);
                    var next = root;
                    foreach (var val in list)
                    {
                        next.next = new ListNode(val);
                        next = next.next;
                    }
                    return root.next;
                }

                return null;
            }
        }
    }
}

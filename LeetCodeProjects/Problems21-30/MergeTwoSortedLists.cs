using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems21_30
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/
    /// </summary>
    public class MergeTwoSortedLists
    {
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                var res = new ListNode(0);
                var current = res;
                while (l1 != null || l2 != null)
                {
                    if (l1 != null && l2 != null)
                    {
                        current.next = new ListNode(Math.Min(l1.val, l2.val));
                        if (l1.val == current.next.val)
                        {
                            l1 = l1.next;
                        }
                        else
                        {
                            l2 = l2.next;
                        }
                    }
                    else if (l1 == null)
                    {
                        current.next = new ListNode(l2.val);
                        l2 = l2.next;
                    }
                    else
                    {
                        current.next = new ListNode(l1.val);
                        l1 = l1.next;
                    }
                    current = current.next;
                }

                return res.next;

            }
        }
    }
}

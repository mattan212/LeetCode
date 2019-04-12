using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems81_90
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list/
    /// </summary>
    public class RemoveDuplicatesFromSortedList
    {
        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {
                var root = new ListNode(head.val);
                var p = root;
                while (head.next != null)
                {
                    head = head.next; //advance the head list

                    if (head.val != p.val)
                    {
                        p.next = new ListNode(head.val);
                        p = p.next;
                    }
                }

                return root;
            }
        }
    }
}

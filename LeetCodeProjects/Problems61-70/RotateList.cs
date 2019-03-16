using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems61_70
{
    /// <summary>
    /// https://leetcode.com/problems/rotate-list/
    /// </summary>
    public class RotateList
    {
        public class Solution
        {
            public ListNode RotateRight(ListNode head, int k)
            {
                if (k == 0 || head == null)
                {
                    return head;
                }
                var list = new List<int>();
                while (head != null)
                {
                    list.Add(head.val);
                    head = head.next;
                }


                var root = new ListNode(0);
                head = root;
                var index = (list.Count - (k % list.Count)) % list.Count;
                foreach (var t in list)
                {
                    root.next = new ListNode(list[index]);
                    index = (index + 1) % list.Count;
                    root = root.next;
                }

                return head.next;
            }
        }
    }
}

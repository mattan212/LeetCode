using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems81_90
{
    /// <summary>
    /// https://leetcode.com/problems/partition-list/
    /// </summary>
    public class PartitionList
    {
        public class Solution
        {
            public ListNode Partition(ListNode head, int x)
            {
                var queue1 = new Queue<int>();
                var queue2 = new Queue<int>();

                while (head != null)
                {
                    if (head.val < x)
                    {
                        queue1.Enqueue(head.val);
                    }
                    else
                    {
                        queue2.Enqueue(head.val);
                    }
                    head = head.next;
                }

                var root = new ListNode(0);
                var child = root;
                while (queue1.Any())
                {
                    child.next = new ListNode(queue1.Dequeue());
                    child = child.next;
                }

                while (queue2.Any())
                {
                    child.next = new ListNode(queue2.Dequeue());
                    child = child.next;
                }

                return root.next;

            }
        }
    }
}

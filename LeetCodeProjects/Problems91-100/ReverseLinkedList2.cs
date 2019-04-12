using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems91_100
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list-ii/
    /// </summary>
    public class ReverseLinkedList2
    {
        public class Solution
        {
            public ListNode ReverseBetween(ListNode head, int m, int n)
            {
                var queue = new Queue<int>();
                var stack = new Stack<int>();

                var index = 1;
                while (head != null)
                {
                    if (index >= m && index <= n)
                    {
                        stack.Push(head.val);
                    }
                    else
                    {
                        queue.Enqueue(head.val);
                    }

                    head = head.next;
                    index++;
                }

                var root = new ListNode(-1);
                var current = root;
                for (var i = 1; i < index; i++)
                {
                    var val = i >= m && i <= n ? stack.Pop() : queue.Dequeue();
                    current.next = new ListNode(val);
                    current = current.next;
                }

                return root.next;
            }
        }
    }
}

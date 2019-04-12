using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Unsorted
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-linked-list/
    /// </summary>
    public class ReverseLinkedList
    {
        public class Solution
        {
            public ListNode ReverseList(ListNode head)
            {
                var stack = new Stack<int>();
                while (head != null)
                {
                    stack.Push(head.val);
                    head = head.next;
                }

                var root = new ListNode(-1);
                var current = root;
                while (stack.Any())
                {
                    current.next = new ListNode(stack.Pop());
                    current = current.next;
                }

                return root.next;
            }
        }
    }
}

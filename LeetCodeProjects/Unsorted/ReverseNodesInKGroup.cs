using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/reverse-nodes-in-k-group/
    /// </summary>
    public class ReverseNodesInKGroup
    {
        public class Solution
        {
            public ListNode ReverseKGroup(ListNode head, int k)
            {
                var root = head;

                Stack<int> intStack = new Stack<int>();
                Queue<ListNode> nodeQueue = new Queue<ListNode>();

                while (head?.next != null)
                {
                    for (var i = 0; i < k && head != null; i++, head = head.next)
                    {
                        intStack.Push(head.val);
                        nodeQueue.Enqueue(head);
                    }

                    if (intStack.Count < k)
                    {
                        break;
                    }

                    while (intStack.Count > 0)
                    {
                        var val = intStack.Pop();
                        var node = nodeQueue.Dequeue();
                        node.val = val;
                    }
                }

                return root;
            }
        }
    }
}

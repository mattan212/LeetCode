using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    class RemoveNthNodeFromEndOfList
    {
        /// <summary>
        /// https://leetcode.com/problems/remove-nth-node-from-end-of-list/
        /// </summary>
        public class Solution
        {
            public ListNode RemoveNthFromEnd(ListNode head, int n)
            {
                var root = new ListNode(0);
                root.next = head;
                var length = 0;
                while (head != null)
                {
                    length++;
                    head = head.next;
                }

                length -= n;
                head = root;

                while (length > 0)
                {
                    length--;
                    head = head.next;
                }

                head.next = head.next.next;

                return root.next;
            }
        }
    }
}

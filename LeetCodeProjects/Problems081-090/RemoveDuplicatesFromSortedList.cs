using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
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

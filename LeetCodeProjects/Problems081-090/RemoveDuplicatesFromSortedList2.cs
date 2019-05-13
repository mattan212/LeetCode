using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/remove-duplicates-from-sorted-list-ii/
    /// </summary>
    public class RemoveDuplicatesFromSortedList2
    {
        public class Solution
        {
            public ListNode DeleteDuplicates(ListNode head)
            {
                if (head == null || head.next == null)
                {
                    return head;
                }

                ListNode root = null;
                ListNode p = null;
                var lastDup = int.MinValue;
                while (head.next != null)
                {
                    if (head.val == head.next.val)
                    {
                        lastDup = head.val;
                        var val = head.val;
                        while (head.next != null && head.val == val)
                        {
                            head = head.next;
                        }
                        continue;
                    }
                    else
                    {
                        if (root == null)
                        {
                            root = new ListNode(head.val);
                            p = root;
                        }
                        else
                        {
                            p.next = new ListNode(head.val);
                            p = p.next;
                        }
                    }

                    head = head.next;
                }

                if (head.val != lastDup)
                {
                    if (p == null)
                    {
                        return head;
                    }
                    p.next = new ListNode(head.val);
                    p = p.next;
                }

                return root;
            }
        }
    }
}

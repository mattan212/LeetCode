using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/
    /// </summary>
    public class AddTwoNumbers
    {
        public class Solution
        {
            public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
            {
                ListNode res = null;
                ListNode p_res = null;

                var carry = 0;
                while (l1 != null || l2 != null || carry != 0)
                {
                    var sum = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
                    carry = sum > 9 ? 1 : 0;
                    sum %= 10;

                    if (res == null)
                    {
                        res = new ListNode(sum);
                        p_res = res;
                    }
                    else
                    {
                        while (res.next != null)
                        {
                            res = res.next;
                        }
                        res.next = new ListNode(sum);
                    }

                    l1 = l1?.next;
                    l2 = l2?.next;
                }

                return p_res;
            }
        }
    }
}

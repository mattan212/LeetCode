using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeProjects.LeetModels;

namespace LeetCodeProjects.Problems21_30
{
    /// <summary>
    /// https://leetcode.com/problems/swap-nodes-in-pairs/
    /// </summary>
    public class SwapNodesInPairs
    {
        public class Solution
        {

            public ListNode SwapPairs(ListNode head)
            {
                var root = head;
                while (head != null && head.next != null)
                {
                    var a = head.val;
                    var b = head.next.val;

                    head.val = b;
                    head.next.val = a;

                    head = head.next.next;
                }

                return root;
            }
        }
    }
}

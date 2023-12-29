using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MiddleNode(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6)))))));

        }

        private static ListNode MiddleNode(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;

            if(head.next == null)
            {
                return head;
            }

            while(slow != null) 
            {
                slow = slow.next;
                fast = fast.next.next;

                if(fast == null || fast.next == null)
                {
                    return slow;
                }
            }

            return slow;
        }
    }
}

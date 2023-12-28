using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteDuplicates(new ListNode(1, new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))))));
        }

        private static ListNode DeleteDuplicates(ListNode head)
        {
            if(head == null)
            {
                return null;
            }

            if(head.next == null)
            {
                return head;
            }

            ListNode current = head;

            while (current.next != null)
            {
                if (current.val == current.next.val)
                {
                    current.next = current.next.next;
                }
                else
                {
                    current = current.next;
                }
            }

            return head;
        }
    }
}

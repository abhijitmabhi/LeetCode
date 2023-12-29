using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RemoveElements(new ListNode(1, new ListNode(2, new ListNode(6, new ListNode(3, new ListNode(4, new ListNode(5, new ListNode(6))))))), 6);

        }

        private static ListNode RemoveElements(ListNode head, int val)
        {
            if(head == null) return null;


            ListNode dummy = new ListNode();
            dummy.next = head;

            ListNode curr = dummy;

            while(curr.next != null)
            {
               if(curr.next.val == val)
                {
                    curr.next = curr.next.next;
                }
               else
                {
                    curr = curr.next;
                }
            }

            return dummy.next;
        }
    }
}

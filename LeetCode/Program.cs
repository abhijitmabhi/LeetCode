using System;
using System.Text;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeleteDuplicates(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))));
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

            ListNode newHead = null;

            // Comment
            while(head != null)
            {
                var tempVal = head.val;

                var tempNode = new ListNode();
                tempNode.val = tempVal;

                tempNode.next = newHead;
                   
                newHead = tempNode;

                head = head.next;
            }

            return newHead;
        }
    }
}

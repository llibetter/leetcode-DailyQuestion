﻿using System;

namespace LC19
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode head = new ListNode(1);
            head.next = new ListNode(2);
            head.next.next = new ListNode(3);
            head.next.next.next = new ListNode(4);
            head.next.next.next.next = new ListNode(5);

            ListNode result = new Solution().RemoveNthFromEnd(head, 2);
            ListNode p=result;
            while(p!=null)
            {
                Console.WriteLine(p.val);
                p=p.next;
            }
            
            Console.Read();
        }
    }
}

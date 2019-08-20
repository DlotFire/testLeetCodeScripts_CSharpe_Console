using System;
using System.Collections.Generic;

namespace tes_ConsoleApp.leetCode
{
    /// <summary>
    /// 链表
    /// </summary>
    class leetCode_4
    {
        private ListNode NodeHead;
        private int[] head;

        public leetCode_4()
        {
            int[] head = new int[] { 4, 5, 1, 9 };


            InitListNodes(head);
            PrintAllListNode();
        }

        /// <summary>
        /// Definition for singly-linked list.
        /// </summary>        
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        /// <summary>
        /// 初始化一个链表
        /// </summary>
        private void InitListNodes(int[] values)
        {
            ListNode LastNode = new ListNode(values[0]);
            NodeHead = LastNode;
            for (int i = 1; i < values.Length; i++)
            {
                ListNode node = new ListNode(values[i]);
                LastNode.next = node;
                LastNode = node;
            }
        }

        /// <summary>
        /// 遍历链表
        /// </summary>
        private void PrintAllListNode()
        {
            ListNode node = NodeHead;
            while (true)
            {
                Console.WriteLine(node.val);
                if (node.next == null)
                {
                    break;
                }
                node = node.next;
            }
        }




    }
}

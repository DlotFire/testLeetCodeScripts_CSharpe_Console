using System;
using System.Collections.Generic;

namespace tes_ConsoleApp.leetCode
{
    /// <summary>
    /// 链表
    /// </summary>
    class leetCode_4
    {
        private ListNode head;

        public leetCode_4()
        {
            //DeleteNode_init();
            RemoveNthFromEnd_init();
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
        private ListNode InitListNodes(ref int[] values)
        {
            ListNode LastNode = new ListNode(values[0]);
            head = LastNode;
            for (int i = 1; i < values.Length; i++)
            {
                ListNode node = new ListNode(values[i]);
                LastNode.next = node;
                LastNode = node;
            }

            return head;
        }

        /// <summary>
        /// 遍历链表
        /// </summary>
        private void PrintAllListNode(ref ListNode node)
        {
            if (node == null)
            {
                return;
            }
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

        private void DeleteNode_init()
        {
            int[] headValue = new int[] { 4, 5, 1, 9 };
            InitListNodes(ref headValue);
            DeleteNode(new ListNode(5));
        }

        /// <summary>
        /// 删除链表中的某个节点（通过）
        /// </summary>
        /// <param name="node"></param>
        private void DeleteNode(ListNode node)
        {
            ListNode eachNode = head;
            while (true)
            {
                if (eachNode.next != null)
                {
                    if (eachNode.next.val == node.val)
                    {
                        eachNode.next = eachNode.next.next;
                    }
                    eachNode = eachNode.next;
                }
                else
                {
                    break;
                }
            }
        }

        private void RemoveNthFromEnd_init()
        {
            int[] values =
                new int[] { 1, 2, 3, 4, 5 };
                //new int[] { 1, 2 };
            ListNode node = InitListNodes(ref values);
            ListNode result = RemoveNthFromEnd(node, 2);
            PrintAllListNode(ref result);
        }

        /// <summary>
        /// 删除链表的倒数第 n 个节点，并且返回链表的头结点（通过，104ms）
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null && n == 1)
            {
                return null;
            }

            ListNode next = head;
            ListNode indexNode = head;
            int countNode = 0;
            while (true)
            {
                ++countNode;

                if (next.next == null)
                {
                    break;
                }
                next = next.next;

                if (countNode > n)
                {
                    indexNode = indexNode.next;
                }
            }

            if (n == 1)
            {
                indexNode.next = null;
                return head;
            }

            if (countNode == n)
            {
                return indexNode.next;
            }
            else
            {
                indexNode.next = indexNode.next.next;
            }
            
            
            return head;
        }
    }
}

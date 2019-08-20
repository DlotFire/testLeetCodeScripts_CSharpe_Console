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
        private int[] headValue;

        public leetCode_4()
        {
            headValue = new int[] { 4, 5, 1, 9 };

            //DeleteNode_init();

            //PrintAllListNode();
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
            head = LastNode;
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
            ListNode node = head;
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
            headValue = new int[] { 4, 5, 1, 9 };
            InitListNodes(headValue);
            DeleteNode(new ListNode(5));
        }

        /// <summary>
        /// 删除链表中的某个节点(非leetCode)
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

        }

        private ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            return null;
        }
    }
}

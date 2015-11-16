using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCodeDataModel;

namespace Leetcode.Tests
{
    internal class DeleteNodeInLinkedList
    {
        public void DeleteNode(ListNode node)
        {
            if (node == null) return;
            if (node.next == null)
            {
                node = null;
                return;
            }
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

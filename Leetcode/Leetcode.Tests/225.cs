using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    public class ImplementingStackUsingQueue
    {

    }

    public class Stack
    {
        private Queue<int> q;
        private int top;
    // Push element x onto stack.
        public Stack()
        {
            q= new Queue<int>();
        }

        public void Push(int x)
        {
            q.Enqueue(x);
            top = x;
        }

        // Removes the element on top of the stack.
        public void Pop()
        {
            var count = q.Count;
            while (count > 1)
            {
                top = q.Dequeue();
                q.Enqueue(top);
                count--;
            }
            q.Dequeue();
        }

        // Get the top element.
        public int Top()
        {
            return top;
        }

        // Return whether the stack is empty.
        public bool Empty()
        {
            return q.Count == 0;
        }
    }
}

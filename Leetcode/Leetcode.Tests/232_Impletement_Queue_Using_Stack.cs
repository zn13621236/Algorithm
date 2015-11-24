using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests
{
    class ImpletementQueueUsingStack
    {
    }


    public class Queue
    {
        private Stack<int> s1;
        private Stack<int> s2;        
        public Queue()
        {
            s1 = new Stack<int>();
            s2 = new Stack<int>();
        }
        // Push element x to the back of queue.
        public void Push(int x)
        {
            s1.Push(x);
    }

        // Removes the element from front of queue.
        public void Pop()
        {
            if (s2.Count ==0)
            {
                while (s1.Count > 0)
                {
                    s2.Push(s1.Pop());
                }
            }

            s2.Pop();
        }

        // Get the front element.
        public int Peek()
        {
            if (s2.Count != 0) return s2.Peek();
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
            return s2.Peek();
        }

        // Return whether the queue is empty.
        public bool Empty()
        {
            return s1.Count == 0 && s2.Count == 0;
        }



    }
}

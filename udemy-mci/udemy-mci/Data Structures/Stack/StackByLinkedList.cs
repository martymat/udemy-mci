using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class StackByLinkedList<T>
    {
        private LinkedListNode<T> top;
        private LinkedListNode<T> bottom;
        private int length;

        public StackByLinkedList()
        {
            top = null;
            bottom = null;
            length = 0;
        }

        public LinkedListNode<T> Peek()
        {
            return top;
        }

        public void Push(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            if (top == null)
            {
                top = newNode;
                bottom = newNode;
            }
            else
            {
                var temp = top;
                top = newNode;
                top.Next = temp;
            }

            length++;
        }

        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("no stack");
            }
            
            top = top.Next;
            length--;
            
        }
    }
}

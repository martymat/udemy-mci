using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
{
    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SinglyLinkedList<T>
    {
        public LinkedListNode<T> head;
        private LinkedListNode<T> tail;
        public int Count { get; private set; }

        public SinglyLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Prepend(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }

            Count++;
        }

        public void Append(T data)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>(data);

            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }

            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }

            head = head.Next;

            if (head == null)
            {
                tail = null;
            }

            Count--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                throw new InvalidOperationException("The linked list is empty.");
            }

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                LinkedListNode<T> currentNode = head;
                while (currentNode.Next != tail)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = null;
                tail = currentNode;
            }

            Count--;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }
    }
}

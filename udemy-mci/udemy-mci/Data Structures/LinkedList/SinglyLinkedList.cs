using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class SinglyLinkedList<T>
    {
        private LinkedListNode<T> head;
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

        /// <summary>
        /// creates a previousNode that starts off as null
        /// points currentNode to previousNode
        /// makes previousNode = currentNode
        /// makes currentNode = nextNode
        /// repeat
        /// </summary>
        public void Reverse()
        {
            if (head == null || head.Next == null)
            {
                Console.WriteLine("Not enough elements to reverse");
            }
            else
            {
                LinkedListNode<T> previousNode = null;
                var currentNode = head;
                var nextNode = currentNode.Next;
                while (nextNode != null)
                {
                    nextNode = currentNode.Next;
                    currentNode.Next = previousNode;
                    previousNode = currentNode;
                    currentNode = nextNode;
                }
                head = previousNode;
            }
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

        public LinkedListNode<T> TraverseToIndex(int indexToTraverseTo)
        {
            int index = 0;
            LinkedListNode<T> currentNode = head;
            if (indexToTraverseTo > this.Count || indexToTraverseTo < 0)
            {
                Console.WriteLine("index out of bounds of linked list");
            }
            else
            {
                while (currentNode.Next != null && index < indexToTraverseTo)
                {
                    currentNode = currentNode.Next;

                    index++;
                }
            }

            return currentNode;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public LinkedListNode<T> GetHead()
        {
            return head;
        }

        public LinkedListNode<T> GetTail()
        {
            return tail;
        }
    }
}

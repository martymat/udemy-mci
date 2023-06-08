using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class LinkedListTester
    {
        private int _multiples;

        public LinkedListTester(int multiples)
        {
            _multiples = multiples;
        }

        public SinglyLinkedList<int> GenerateAndGetSinglyLinkedList()
        {
            var linkedList = new SinglyLinkedList<int>();
            int data = 0;
            // Add 5 nodes to the linked list
            for (int i = 0; i < 5; i++)
            {
                data += _multiples;
                linkedList.Append(data);
            }

            return linkedList;
        }

        public void ReverseSinglyLinkedList()
        {
            var linkedListToReverse = GenerateAndGetSinglyLinkedList();
            linkedListToReverse.Reverse();

            // Print the linked list
            LinkedListNode<int> currentNode = linkedListToReverse.GetHead();
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }
    }
}

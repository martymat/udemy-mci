using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    class StackByLinkedListTester
    {
        private int _multiples;

        public StackByLinkedListTester(int multiples)
        {
            _multiples = multiples;
        }

        public StackByLinkedList<int> GenerateAndGetStackByLinkedList()
        {
            var linkedList = new StackByLinkedList<int>();
            int data = 0;
            // Add 5 nodes to the linked list
            for (int i = 0; i < 5; i++)
            {
                data += _multiples;
                linkedList.Push(data);
            }

            return linkedList;
        }

        public void TestStackByLinkedList()
        {
            var stackByLinkedList = GenerateAndGetStackByLinkedList();

            stackByLinkedList.Pop();

            // Print the linked list
            LinkedListNode<int> currentNode = stackByLinkedList.Peek();
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Data);
                currentNode = currentNode.Next;
            }
        }

    }
}

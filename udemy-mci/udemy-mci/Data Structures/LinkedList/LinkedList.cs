using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class LinkedList
    {
        private int _multiples;

        public LinkedList(int multiples)
        {
            _multiples = multiples;
        }

        public SinglyLinkedList<int> GenerateAndGetSinglyLinkedList()
        {
            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>();
            int data = _multiples;
            // Add 5 random nodes to the linked list
            for (int i = 0; i < 5; i++)
            {
                data += 5;
                linkedList.Append(data);
            }

            return linkedList;
        }

        public void ReverseSinglyLinkedList()
        {
            var linkedListToReverse = GenerateAndGetSinglyLinkedList();


        }
    }
}

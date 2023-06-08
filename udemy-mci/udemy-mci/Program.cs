using System;
using udemy_mci.DataStructures;

namespace udemy_mci
{
    class Program
    {
        static void Main(string[] args)
        {
            //ReverseString.Reverse();

            //MergeArrays.Merge();

            //HashSet.FindFirstReoccuringCharacter();

            //var linkedList = new LinkedListTester(5);
            //linkedList.ReverseSinglyLinkedList();

            var stackByLinkedListTester = new StackByLinkedListTester(5);
            stackByLinkedListTester.TestStackByLinkedList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    // create max heap
    // remove largest item
    // place item in sorted partition

    public class HeapSort
    {
        public static void SortTest()
        {
            var arr = new List<int>() { 5, 8, 3, 9, 4, 1, 7 };

            var sortedArray = Sort(arr);

            foreach (var number in sortedArray)
                Console.Write(number + " ");
        }

        public static List<int> Sort(List<int> arr)
        {
            //           5
            //      8         3
            //   9     4   1     7

            // build max heap
            BuildMaxHeap(arr);

            //           9
            //      8         7
            //   5     4   1     3

            // extract elements from the heap one by one
            for (int treeSize = arr.Count - 1; treeSize > 0; treeSize--)
            {
                // swap the root (maximum element) with the last element
                SwapHelper.Swap(arr, treeSize, 0);

                // heapify (correct) the newly trimmed heap
                Heapify(arr, treeSize, 0);
            }

            return arr;
        }

        public static void BuildMaxHeap(List<int> arr)
        {
            var lastNonLeafNodeIndex = arr.Count / 2 - 1;
            for (; lastNonLeafNodeIndex >= 0; lastNonLeafNodeIndex--)
                Heapify(arr, arr.Count, lastNonLeafNodeIndex);
        }

        public static void Heapify(List<int> arr, int treeSize, int rootIndex)
        {
            // assume that rootIndex has the largest value
            int largestIndex = rootIndex;
            var leftChildIndex = (rootIndex * 2) + 1;
            var rightChildIndex = (rootIndex * 2) + 2; 

            // if left child is larger than root
            if (leftChildIndex < treeSize && arr[leftChildIndex] > arr[largestIndex])
                largestIndex = leftChildIndex;

            // if right child is larger than the largest so far
            if (rightChildIndex < treeSize && arr[rightChildIndex] > arr[largestIndex])
                largestIndex = rightChildIndex;

            // if the largest is not the root
            if (largestIndex != rootIndex)
            {
                // swap the largest element with the root
                SwapHelper.Swap(arr, largestIndex, rootIndex);

                // recursively heapify the affected sub-tree
                Heapify(arr, treeSize, largestIndex);
            }
        }
    }
}

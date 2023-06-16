using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class QuickSort2
    {
        public static void SortTest()
        {
            var arr = new List<int>() { 2, 5, 3, 1, 8, 7, 6, 4 };
            quick_sort(arr);

            foreach (var number in arr)
                Console.WriteLine(number + " ");
        }

        private static List<int> quick_sort(List<int> arr)
        {
            // call helper function
            // pass it array, start index, and end index
            PartitionHelper(arr, 0, arr.Count - 1);

            return arr;
        }


        // Lamuto's Partitioning 
        private static void PartitionHelper(List<int> arr, int startIndex, int endIndex)
        {
            if (startIndex >= endIndex)
                return;

            var smallIndex = startIndex;
            var bigIndex = startIndex + 1;

            Random random = new Random();
            var pivotIndex = random.Next(startIndex, endIndex);

            Swap(arr, startIndex, pivotIndex);

            for (; bigIndex <= endIndex; bigIndex++)
            {
                if (arr[bigIndex] < arr[startIndex])
                {
                    smallIndex++;

                    Swap(arr, smallIndex, bigIndex);
                }
            }

            Swap(arr, startIndex, smallIndex);

            PartitionHelper(arr, startIndex, smallIndex - 1);
            PartitionHelper(arr, smallIndex + 1, endIndex);
        }

        private static void Swap(List<int> arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class QuickSort
    {
        private static int[] arrayToSort = new int[8] { 2, 5, 3, 1, 8, 7, 6, 4 };

        public static void SortTest()
        {
            Sort(arrayToSort, 0, arrayToSort.Length - 1);

            foreach (var number in arrayToSort)
                Console.WriteLine(number + " ");
        }

        private static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Partition the array and get the pivot index
                int pivotIndex = Partition(arr, low, high);

                // Recursively sort the subarrays before and after the pivot
                Sort(arr, low, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, high);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];   // Choose the rightmost element as the pivot
            int i = low - 1;         // Index of the smaller element

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);  // Swap elements at positions i and j
                }
            }

            Swap(arr, i + 1, high);   // Swap the pivot element with the element at i + 1
            return i + 1;             // Return the updated pivot index
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}

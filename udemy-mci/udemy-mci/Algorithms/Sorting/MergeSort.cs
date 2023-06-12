using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class MergeSort
    {
        private static int[] arrayToSort = new int[8] { 2, 5, 3, 1, 8, 7, 6, 4 };

        public static void SortTest()
        {
            Sort(arrayToSort, 0, arrayToSort.Length - 1);

            foreach (var number in arrayToSort)
                Console.WriteLine(number + " ");
        }

        private static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;

                // Recursive calls to sort the left and right halves of the array
                Sort(arr, left, mid);
                Sort(arr, mid + 1, right);

                // Merge the sorted halves
                Merge(arr, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;    // Size of the left subarray
            int n2 = right - mid;       // Size of the right subarray

            int[] leftArr = new int[n1];    // Create temporary array for the left subarray
            int[] rightArr = new int[n2];   // Create temporary array for the right subarray

            // Copy elements from the original array to temporary arrays
            Array.Copy(arr, left, leftArr, 0, n1);
            Array.Copy(arr, mid + 1, rightArr, 0, n2);

            int i = 0, j = 0;
            int k = left;

            // Merge the left and right subarrays back into the original array in sorted order
            while (i < n1 && j < n2)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            // Copy any remaining elements from the left subarray, if any
            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            // Copy any remaining elements from the right subarray, if any
            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }

        }
    }
}

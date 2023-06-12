using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    class InsertionSort
    {
        private static int[] arrayToSort = new int[8] { 2, 5, 3, 1, 8, 7, 6, 4 };

        public static void Sort()
        {
            for (int i = 1; i < arrayToSort.Length; i++)
            {
                int key = arrayToSort[i]; // Current element to be inserted at the correct position
                int j = i - 1;

                // Move elements of arrayToSort[0..i-1], that are greater than key, to one position ahead of their current position
                while (j >= 0 && arrayToSort[j] > key)
                {
                    arrayToSort[j + 1] = arrayToSort[j]; // Shift the element to the right
                    j--;
                }

                arrayToSort[j + 1] = key; // Insert the key at the correct position in the sorted subarray
            }

            foreach (var number in arrayToSort)
                Console.WriteLine(number + " ");
        }
    }
}

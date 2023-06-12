using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class SelectionSort
    {
        private static int[] arrayToSort = new int[8] { 2, 5, 3, 1, 8, 7, 6, 4 };

        /// <summary>
        /// loop through array with nested loops
        ///     find index with smallest value with inner loop
        ///     swap out value in outer loop
        /// </summary>
        public static void Sort()
        {
            for (int i = 0; i <= arrayToSort.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i; j <= arrayToSort.Length - 1; j++)
                {
                    if (arrayToSort[j] < arrayToSort[minIndex])
                    {
                        minIndex = j;
                    }
                }

                int temp = arrayToSort[i];
                arrayToSort[i] = arrayToSort[minIndex];
                arrayToSort[minIndex] = temp;
            }

            foreach (var number in arrayToSort)
                Console.WriteLine(number + " ");
        }
    }
}

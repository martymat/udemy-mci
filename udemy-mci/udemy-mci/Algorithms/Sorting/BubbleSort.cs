using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class BubbleSort
    {
        private static int[] arrayToSort = new int[8] { 6, 5, 3, 1, 8, 7, 2, 4 };

        /// <summary>
        /// loop through array with nested loops
        ///     compare arrayToSort[i] to arrayToSort[j]
        ///     if greater, swap and increment i and j
        ///     if not greater, increment i and j
        /// </summary>
        public static void Sort()
        {
            for (int i = 0; i < arrayToSort.Length - 1; i++)
            {
                for (int j = 0; j < arrayToSort.Length - i - 1; j++)
                {
                    if (arrayToSort[j] > arrayToSort[j + 1])
                    {
                        // Swap arrayToSort[j] and arrayToSort[j+1]
                        int temp = arrayToSort[j];
                        arrayToSort[j] = arrayToSort[j + 1];
                        arrayToSort[j + 1] = temp;
                    }
                }
            }

            foreach (var number in arrayToSort)
                Console.WriteLine(number + " ");
        }
    }
}

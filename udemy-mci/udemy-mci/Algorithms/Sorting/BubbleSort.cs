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
        ///     compare arrayToSort[j] to arrayToSort[j+1]
        ///     if greater, swap and increment arrayToSort[j] and arrayToSort[j+1]
        /// </summary>
        public static void Sort()
        {
            for (int i = 0; i < arrayToSort.Length; i++)
            {
                for (int j = 0; j < arrayToSort.Length - i; j++)
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

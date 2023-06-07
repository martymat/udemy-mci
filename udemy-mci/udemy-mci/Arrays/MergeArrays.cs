using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace udemy_mci.Arrays
{
    class MergeArrays
    {
        // test case 1
        private static int[] array1 = new int[8] { 0, 3, 4, 31, 34, 34, 34, 34 };
        private static int[] array2 = new int[5] { 4, 6, 30, 333, 466 };

        // test case 2
        //private static int[] array1 = new int[0] { };
        //private static int[] array2 = new int[1] { 4 };

        public static void Merge()
        {
            // loop arrays
            // whichever array item is bigger, put the other array item in the returnArray
            //  then continue to compary until a bigger item is found
            //  then switch array of which your comparing against

            int index1 = 0;
            int index2 = 0;
            int returnArrayIndex = 0;
            int[] returnArray = new int[array1.Length + array2.Length];

            while (index1 < array1.Length && index2 < array2.Length)
            {
                if (array1[index1] < array2[index2])
                {
                    returnArray[returnArrayIndex++] = array1[index1++];
                }
                else
                {
                    returnArray[returnArrayIndex++] = array2[index2++];
                }
            }

            // fill in rest
            while (index1 < array1.Length)
            {
                returnArray[returnArrayIndex++] = array1[index1++];
            }

            while (index2 < array2.Length)
            {
                returnArray[returnArrayIndex++] = array2[index2++];
            }

            // print
            foreach (var value in returnArray)
            {
                Console.WriteLine(value);
            }
        }
    }
}

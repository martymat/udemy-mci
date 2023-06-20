using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace udemy_mci.Algorithms
{
    public class RadixSort
    {
        //private static List<int> arr = new List<int> { 1, 0, 3, 1, 3, 1 };
        //private static List<int> arr = new List<int> { -400000 };

        public static void SortTest()
        {
            var arr = new List<int> { 21, 345, 13, 101, 50, 234, 1 };
            var max = arr.Max();

            // Perform counting sort for each digit, starting from the least significant digit to the most significant digit
            for (int position = 1; max / position > 0; position *= 10)
                CountingSort(arr, arr.Count, position);

            foreach (var number in arr)
                Console.WriteLine(number + " ");
        }

        public static void CountingSort(List<int> arr, int length, int position)
        {
            var frequency = new Dictionary<int, List<int>>();
            int digit;

            var min = 0;
            var max = 10;

            for (int i = 0; i < length; i++)
            {
                digit = DigitAtPosition(arr[i], position);

                if (!frequency.ContainsKey(digit))
                {
                    var values = new List<int>() { arr[i] };
                    frequency.Add(digit, values);
                }
                else
                {
                    frequency[digit].Add(arr[i]);
                }
            }

            int arr_index = 0;
            for (int i = min; i <= max; i++)
            {
                if (frequency.ContainsKey(i))
                {
                    foreach (var value in frequency[i])
                    {
                        arr[arr_index++] = value;
                    }
                }
            }
        }

        public static int DigitAtPosition(int Number, int Position)
        {
            return ((Number / Position) % 10);
        }
    }
}

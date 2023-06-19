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
            var arr = new List<int> { 1, 0, 3, 1, 3, 1 };
            var max = arr.Max();

            // Perform counting sort for each digit, starting from the least significant digit to the most significant digit
            for (int exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, arr.Count, exp);

            foreach (var number in arr)
                Console.WriteLine(number + " ");
        }

        public static void CountingSort(List<int> arr, int length, int exp)
        {
            var frequency = new Dictionary<int, int>();

            var min = arr.Min();
            var max = arr.Max();

            for (int i = 0; i < arr.Count; i++)
            {
                if (!frequency.ContainsKey(arr[i]))
                    frequency.Add(arr[i], 1);
                else
                    frequency[arr[i]]++;
            }

            int arr_index = 0;
            for (int i = min; i <= max; i++)
            {
                if (frequency.ContainsKey(i))
                {
                    var current_frequency = frequency[i];
                    while (current_frequency > 0)
                    {
                        arr[arr_index++] = i;

                        current_frequency--;
                    }
                }
            }
        }

        public static void CountingSort2(List<int> list, int length, int exp)
        {
            List<int> output = new List<int>(new int[length]);
            int[] count = new int[10];

            // Initialize the count array with all zeros
            for (int i = 0; i < 10; i++)
                count[i] = 0;

            // Store the count of each digit at their respective index in the count array
            for (int i = 0; i < length; i++)
                count[(list[i] / exp) % 10]++;

            // Change count[i] so that count[i] contains the actual position of this digit in the output array
            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            // Build the output array by placing each element in its corresponding position based on the current digit
            for (int i = length - 1; i >= 0; i--)
            {
                output[count[(list[i] / exp) % 10] - 1] = list[i];
                count[(list[i] / exp) % 10]--;
            }

            // Copy the output array to the original list, so that the list contains the sorted elements based on the current digit
            for (int i = 0; i < length; i++)
                list[i] = output[i];
        }
    }
}

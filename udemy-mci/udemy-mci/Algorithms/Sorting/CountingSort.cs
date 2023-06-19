using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class CountingSort
    {
        private static List<int> arr = new List<int> { 1, 0, 3, 1, 3, 1 };
        //private static List<int> arr = new List<int> { -400000 };

        public static void SortTest()
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

            foreach (var number in arr)
                Console.WriteLine(number + " ");
        }

        public static void SortTest2()
        {
            int min = arr.Min();
            int max = arr.Max();
            int[] counts = new int[max - min + 1];

            for (int i = 0; i < arr.Count; i++)
            {
                counts[arr[i] - min]++;
            }

            int k = arr.Count - 1;

            for (int j = max; j >= min; j--)
            {
                for (int i = 0; i < counts[j - min]; i++)
                {
                    arr[k--] = j;
                }
            }


            foreach (var number in arr)
                Console.WriteLine(number + " ");
        }
    }
}

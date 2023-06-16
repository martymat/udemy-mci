using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class MergeSort2
    {
        public static List<int> merge_sort()
        {
            // 5, 8, 3, 9, 4, 1, 7
            // 1, 3, 4, 5, 7, 8, 9

            // divide arr into 2 halves (start - mid / mid+1 - end)
            // recursively keep doing that (sending halves to lower managers)
            // merge

            var arr = new List<int>() { 2, 5, 3, 1, 8, 7, 6, 4 };

            var start = 0;
            var end = arr.Count - 1;

            merge_sort_R(arr, start, end);

            return arr;
        }


        private static void merge_sort_R(List<int> arr, int start, int end)
        {
            if (start < end)
            {
                var mid = start + ((end - start) / 2);
                merge_sort_R(arr, start, mid);
                merge_sort_R(arr, mid + 1, end);

                merge(arr, start, mid, end);
            }
        }

        private static void merge(List<int> arr, int start, int mid, int end)
        {

            var i = start;
            var j = mid + 1;

            var auxArray = new List<int>();

            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    auxArray.Add(arr[i]);
                    i++;
                }
                else if (arr[j] < arr[i])
                {
                    auxArray.Add(arr[j]);
                    j++;
                }
            }

            while (i <= mid)
            {
                auxArray.Add(arr[i]);
                i++;
            }

            while (j <= end)
            {
                auxArray.Add(arr[j]);
                j++;
            }

            int auxIndex = 0;
            for (i = start; i <= end; i++)
            {
                arr[i] = auxArray[auxIndex++];
            }
        }
    }
}

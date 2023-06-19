using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public static class SwapHelper
    {
        public static void Swap(List<int> arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
        public static void Swap(int[] arr, int index1, int index2)
        {
            int temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
        }
    }
}

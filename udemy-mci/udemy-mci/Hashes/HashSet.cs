using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Hashes
{
    class HashSet
    {
        // test case 1
        //private static int[] array = new int[9] { 2, 5, 1, 2, 3, 5, 1, 2, 4 };

        // test case 2
        //private static int[] array = new int[9] { 2, 1, 1, 2, 3, 5, 1, 2, 4 };

        // test case 3
        private static int[] array = new int[4] { 1, 2, 3, 4 };

        public static void FindFirstReoccuringCharacter()
        {
            HashSet<int> hashSet = new HashSet<int>();
            foreach (var value in array)
            {
                if (hashSet.Contains(value))
                {
                    Console.WriteLine(value);
                    break;
                }

                hashSet.Add(value);
            }
        }
    }
}

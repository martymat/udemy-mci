using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DataStructures
{
    public class ReverseString
    {
        private const string stringToReverse = "racecar";

        public static void Reverse()
        {
            int stringLength = stringToReverse.Length;
            int index = 0;
            int reverseIndex = stringLength - 1;

            char[] reversedStringAsCharArray = new char[stringLength];
            while (index < stringLength || index < reverseIndex)
            {
                reversedStringAsCharArray[index] = stringToReverse[reverseIndex];

                index++;
                reverseIndex--;
            }

            string reversedString = new string(reversedStringAsCharArray);
            Console.WriteLine(reversedString);
        }
    }
}

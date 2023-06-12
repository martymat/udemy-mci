using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class Factorial
    {
        public static void FactorialIterative(int number)
        {
            int product = number;
            if (number == 2)
            {
                product = 2;
            }

            for (int i = 2; i <= number; i++)
            {
                product *= i;
            }

            Console.WriteLine(product);
        }

        public static int FactorialRecursive(int number)
        {
            if (number == 2)
            {
                return number;
            }

            return number *= FactorialRecursive(number - 1);
        }
    }
}

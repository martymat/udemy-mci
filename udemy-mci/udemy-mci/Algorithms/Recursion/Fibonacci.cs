using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.Algorithms
{
    public class Fibonacci
    {
        public static void FibonacciIterative(int number)
        {
            // 0, 1, 1
            int prev1 = 1;
            int prev2 = 0;
            int sum = (prev1 + prev2);

            // 2, 3, 5, 8
            for (int i = 2; i < number + 1; i++)
            {
                sum = (prev1 + prev2);
                prev2 = prev1;
                prev1 = sum;
            }

            Console.WriteLine(sum);
        }

        public static int FibonacciRecursive(int number, string message)
        {
            // 0, 1, 1
            if (number < 2)
            {
                return number;
            }

            // 2, 3, 5, 8
            var fib1 = FibonacciRecursive(number - 1, "minus 1");
            var fib2 = FibonacciRecursive(number - 2, "minus 1");
            var answer = fib1 + fib2;

            return answer;

        }
    }
}

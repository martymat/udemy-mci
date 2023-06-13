using System;
using System.Collections.Generic;
using System.Text;

namespace udemy_mci.DynamicProgramming
{
    public class Memoization
    {
        private static Dictionary<int, long> cache = new Dictionary<int, long>();

        public static long Fibonacci(int n)
        {
            if (n <= 1)
                return n;

            if (cache.ContainsKey(n))
                return cache[n];

            long fibValue = Fibonacci(n - 1) + Fibonacci(n - 2);
            cache[n] = fibValue;

            return fibValue;
        }
    }
}

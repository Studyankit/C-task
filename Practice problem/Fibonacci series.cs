using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problem
{
     class Fibonacci_series
    {
        static int fib(int n)
        {

            int[] fibs = new int[n + 2];

            fibs[0] = 0;
            fibs[1] = 1;

            for (int i = 2; i <= n; i++)
            {
                
                fibs[i] = fibs[i - 1] + fibs[i - 2];

            }

            return fibs[n];
        }

        // Driver Code
        public static void Main()
        {
            int n = 9;
            Console.WriteLine(fib(n));
        }
    }
}

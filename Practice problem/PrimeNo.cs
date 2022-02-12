using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problem
{
    internal class PrimeNo
    {
        public static void Prime()
        {
            int flag = 0; 
            Console.WriteLine("Write the no to check if it's prime or not");
            int primeNo = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i < primeNo/2; i++)
            {
                if (primeNo % i == 0)
                {
                    flag= 1;
                    Console.WriteLine("It's not a prime no");
                    break;
                }
            }
              if (flag == 0)
            {
                Console.WriteLine("It's prime no");
            }
              Console.ReadLine();
        }
    }
}

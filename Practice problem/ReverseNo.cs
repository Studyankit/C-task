using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problem
{
    internal class ReverseNo
    {
        public static void revers()
        {
            int revNo;
            Console.Write("Input no to reverse ");
            int orgNo = Convert.ToInt32(Console.ReadLine());

            while (orgNo != 0)
            {
                revNo = orgNo % 10;
                revNo = revNo % 10 + orgNo;
                orgNo /= 10;
            }

            
        }
    }
}

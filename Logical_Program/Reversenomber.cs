using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class Reversenomber
    {
        public void reverse()
        {
            int n, i, rev = 0;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());

            while(n>0)
            {
                i = n % 10;
                rev = rev * 10 + i;
                n = n / 10;
            }
            Console.WriteLine("Reverse number is:" + rev);
        }
    }
}

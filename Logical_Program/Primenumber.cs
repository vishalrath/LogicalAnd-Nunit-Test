using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class Primenumber
    {
        public void prime()
        {
            int n, i, primeno;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=2; i<=n/2; i++)
            {
                primeno = n % i;
                if (primeno == 0)
                {
                    Console.WriteLine("number is not prime");
                }
                else
                {
                    Console.WriteLine("this is prime number");
                }
            }
        }
    }
}

using System;

namespace Logical_Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1.Fibonassi\n2.Primenumber Series\n3.Reversenomber\n4.Perfectnumber\n5.Coupon\n6.Stopwatch");
            Console.WriteLine("Enter your choice:");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Fibonacii fib = new Fibonacii();
                    fib.fibo();
                    break;

                case 2:
                    Primenumber pnum = new Primenumber();
                    pnum.prime();
                    break;

                case 3:
                    Reversenomber rnum = new Reversenomber();
                    rnum.reverse();
                    break;

                case 4:
                    Perfectnumber pernumber = new Perfectnumber();
                    pernumber.pnum();
                    break;

                case 5:
                    Coupon mycoupon = new Coupon();
                    mycoupon.coup();
                    break;
               /* case 6:
                    Stopwatch stop = new Stopwatch();
                    stop.start();
                    stop.stop();
                    stop.getElapsedTime();
                    stop.getElapsedTimeSecs();
                    break;*/
                default:
                    Console.WriteLine("Invalid choice.. ");
                    break;
            }
        }
    }
}

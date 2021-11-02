using System;

namespace NUnit_Testing_logical_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

         
            validation:
                try
                {
                    bool flag = true;
                    while (flag)
                    {
                        Console.WriteLine("\n1.Vending Machine  \n2.Day of a week \n3.Temperature Conversion\n4.Monthly Payment installment " +
                           "\n5.Square Root \n6.Binary Conversion and swapping nibbles \n7.Exit ");
                        Console.WriteLine("\nEnter Your Option:");
                        int option = Convert.ToInt32(Console.ReadLine());       // converting string value to int
                    switch (option)
                    {
                        case 1:
                            VendingMachine change = new VendingMachine();
                            break;
                        case 2:
                           
                            int month = Convert.ToInt32(args[0]);
                            int day = Convert.ToInt32(args[1]);
                            int year = Convert.ToInt32(args[2]);
                            DayOfWeek.Days(month, day, year);
                            break;

                        case 3:
                            TemperatureConversion.Conversion();
                            break;

                        case 4:
                            MonthlyPayment.Payments(args[3], args[4], args[5]);
                            break;

                        case 5:
                            SquareRoot.Sqrt();
                            break;
                        case 6:
                            BinaryConver.ToBinary();
                            break;
                        case 7:
                            flag = false;
                            break;

                        default:
                            Console.WriteLine("Wrong option! please enter option again.");
                            break;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Please Enter valid Input");
                    goto validation;
                }

                Console.ReadKey();
               
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Program
{
    class Fibonacii
    {
        public void fibo()
        {

            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());
            //printing 0 and 1
            Console.Write(n1 + " " + n2 + " ");
            //loop starts from 2 because 0 and 1 are already printed  
            for (i = 2; i < number; ++i)          
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }  
}



 AddDetails Data = new AddDetails();
            Data.Details();
            Console.ReadLine();


public void Details()
            {
                Console.WriteLine("Welcome to my address book program");
                Console.WriteLine("Please Enter your Firstname");

                string str1 = "Firstname";
                str1 = Console.ReadLine();
                string valueString1 = str1;

                Console.WriteLine("Please Enter your Lastname");
                string str2 = "Lastname";
                str2 = Console.ReadLine();
                string valueString2 = str2;

                Console.WriteLine("Please Enter your mobile number");
                string mobileno = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Please Enter your Address");
                string Address = Convert.ToString(Console.ReadLine());


                Console.WriteLine("Please Enter your City");
                string str5 = "City";
                str5 = Console.ReadLine();
                string valueString5 = str5;

                Console.WriteLine("Please Enter your Postcode");
                string str6 = "Postcode";
                str6 = Console.ReadLine();
                string valueString6 = str6;

                Console.WriteLine("Please Enter your State");
                string str7 = "State";
                str6 = Console.ReadLine();
                string valueString7 = str7;
                Console.WriteLine("Please Enter your Email");
                string str8 = "Email";
                str6 = Console.ReadLine();
                string valueString8 = str8;



                Console.WriteLine("Here is a list of the stored Detais");
                Console.ReadLine();
                Console.WriteLine("Firstnameis: " + valueString1);
                Console.WriteLine("Lastname is: " + valueString2);
                Console.WriteLine("Address is : " + Address);
                Console.WriteLine("mobile no is : " + mobileno);
                Console.WriteLine("City is: " + valueString5);
                Console.WriteLine("Postcode is: " + valueString6);
                Console.WriteLine("State  is: " + valueString7);
                Console.WriteLine("Email id  is: " + valueString8);

            }
        }
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("What is your name?");
                var name = Console.ReadLine();
                Console.WriteLine("Hello, " + name + "!");
                Console.WriteLine("I’ll guess three integers now, show the sum and product of these numbers, your task is to guess these numbers. Good luck!");
                Random rnd = new Random();


                int value1 = rnd.Next(2, 8);
                int value2 = rnd.Next(2, 8);
                int value3 = rnd.Next(2, 8);


                var sum = value1 + value2 + value3;
                var product = value1 * value2 * value3;

                Console.WriteLine(sum + " - sum of three numbers");
                Console.WriteLine(product + " - product of three numbers");

                

                int userValue1; 
                int userValue2;
                int userValue3;



                Console.WriteLine("Enter the desired numbers in the range from 2 to 7");
                userValue1 = Convert.ToInt32(Console.ReadLine());
                userValue2 = Convert.ToInt32(Console.ReadLine());
                userValue3 = Convert.ToInt32(Console.ReadLine());

                var sumUser = userValue1 + userValue2 + userValue3;
                var productUser = userValue1 * userValue2 * userValue3;

                if (sumUser == sum || product == productUser)
                {
                    Console.WriteLine("You won! Respect!");
                }

                else
                {
                    Console.WriteLine("No luck, try again");
                    Console.WriteLine("1 number was made up - "+value1); 
                    Console.WriteLine("2 number was made up - " + value2);
                    Console.WriteLine("3 number was made up - " + value3);
                    Console.WriteLine("Press Enter to try again...");
                }


                Console.ReadKey();

            }

        }
    }
}

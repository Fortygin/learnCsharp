using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
    class Program
    {
        static string GetPlayerName()
        {
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("I’ll guess three integers now, show the sum and product of these numbers,\nyour task is to guess these numbers.\nGood luck!");

            return name;
        }
      
          
        static void Main(string[] args)
        {
            string PlayerName = GetPlayerName();

            while (true)
            {

                
                
                Random rnd = new Random();


                int value1 = rnd.Next(2, 8);
                int value2 = rnd.Next(2, 8);
                int value3 = rnd.Next(2, 8);


                var sum = value1 + value2 + value3;
                var product = value1 * value2 * value3;

                Console.WriteLine(sum + " - sum of three numbers");
                Console.WriteLine(product + " - product of three numbers");

                Console.WriteLine("Enter the desired numbers in the range from 2 to 7");

                int userValue1 = GetUserInput();
                int userValue2 = GetUserInput();
                int userValue3 = GetUserInput();


                var sumUser = userValue1 + userValue2 + userValue3;
                var productUser = userValue1 * userValue2 * userValue3;

                if (sumUser == sum || product == productUser)
                {
                    Console.WriteLine("You won! Respect!");
                }

                else
                {
                    Console.WriteLine("No luck, try again");
                    Console.WriteLine("1 number was made up - " + value1);
                    Console.WriteLine("2 number was made up - " + value2);
                    Console.WriteLine("3 number was made up - " + value3);
                    Console.WriteLine("Press Enter to try again...");
                }

               
                if (ContinueGame() == true)
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.WriteLine("Thanks for playing! Bye!");
                    Console.ReadKey();
                    break;
                    
                }
                
                


            }

        }

        static bool ContinueGame()
        {
            
            Console.WriteLine("What to continue the game? Choose your answer option 1 - YES!\nIf you want to end the game, press any button");

            if (Console.ReadLine() == "1")
            {
                return true;
            }
            
            else
            {
                return false;
            }
        
            

        }

        static int GetUserInput()
        {
            

            while (true)
            {
                Console.WriteLine("Input a number from 2 to 7");
                if (int.TryParse(Console.ReadLine(), out int result))
                {
                    return result;
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    Console.WriteLine("Try again");
                }
            }

            
            
        }



    }
}

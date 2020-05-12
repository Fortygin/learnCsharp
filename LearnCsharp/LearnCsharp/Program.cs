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
            Console.WriteLine("Welcome to the game! The game features 5 levels, try to complete them all!\nGood luck!");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");


            return name;
        }




        static void Main(string[] args)
        {
            string PlayerName = GetPlayerName();



            while (true)
            {



                if (Level1())
                {

                }
                else
                {
                    Console.WriteLine("You lose! Try again!");
                    Console.WriteLine("You level - 0");

                    if (ContinueGame())
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


                if (Level2())
                {

                }
                else
                {
                    Console.WriteLine("You lose! Try again!");
                    Console.WriteLine("You level - 1");
                    if (ContinueGame())
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

                if (Level3())
                {

                }
                else
                {
                    Console.WriteLine("You lose! Try again!");
                    Console.WriteLine("You level - 2");
                    if (ContinueGame())
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
                if (Level4())
                {

                }
                else
                {
                    Console.WriteLine("You lose! Try again!");
                    Console.WriteLine("You level - 3");
                    if (ContinueGame())
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
                if (Level5())
                {

                    if (ContinueGame())
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
                else
                {
                    Console.WriteLine("You lose! Try again!");
                    Console.WriteLine("You level - 4");
                    if (ContinueGame())
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
        static bool Level1()
        {
            Console.WriteLine("1 level");
            Console.WriteLine("RULES:\nI made up three numbers in the range from 2 to 4,\nI will show you the sum and product of these numbers, your task is to guess them!");
            Random rnd = new Random();


            int value1 = rnd.Next(2, 5);
            int value2 = rnd.Next(2, 5);
            int value3 = rnd.Next(2, 5);


            var sum = value1 + value2 + value3;
            var product = value1 * value2 * value3;

            Console.WriteLine(sum + " - sum of three numbers");
            Console.WriteLine(product + " - product of three numbers");

            Console.WriteLine("Enter the desired numbers in the range from 2 to 4");
            int userValue1 = GetUserInput();
            int userValue2 = GetUserInput();
            int userValue3 = GetUserInput();


            var sumUser = userValue1 + userValue2 + userValue3;
            var productUser = userValue1 * userValue2 * userValue3;

            if (sumUser == sum && product == productUser)
            {
                Console.WriteLine("You won! The next level is waiting for you!");
                return true;
            }

            else
            {
                Console.WriteLine("No luck, try again");
                Console.WriteLine("1 number was made up - " + value1);
                Console.WriteLine("2 number was made up - " + value2);
                Console.WriteLine("3 number was made up - " + value3);


                return false;
            }
        }

        static bool Level2()
        {
            Console.WriteLine("Level 2");
            Console.WriteLine("RULES:\nI made up three numbers in the range from 2 to 5,\nI will show you the sum and product of these numbers, your task is to guess them!");
            Random rnd = new Random();


            int value1 = rnd.Next(2, 6);
            int value2 = rnd.Next(2, 6);
            int value3 = rnd.Next(2, 6);


            var sum = value1 + value2 + value3;
            var product = value1 * value2 * value3;

            Console.WriteLine(sum + " - sum of three numbers");
            Console.WriteLine(product + " - product of three numbers");

            Console.WriteLine("Enter the desired numbers in the range from 2 to 5");
            int userValue1 = GetUserInput();
            int userValue2 = GetUserInput();
            int userValue3 = GetUserInput();


            var sumUser = userValue1 + userValue2 + userValue3;
            var productUser = userValue1 * userValue2 * userValue3;

            if (sumUser == sum && product == productUser)
            {
                Console.WriteLine("You won! The next level is waiting for you!");
                return true;
            }

            else
            {
                Console.WriteLine("No luck, try again");
                Console.WriteLine("1 number was made up - " + value1);
                Console.WriteLine("2 number was made up - " + value2);
                Console.WriteLine("3 number was made up - " + value3);


                return false;
            }
        }

        static bool Level3()
        {
            Console.WriteLine("Level 3");
            Console.WriteLine("RULES:\nI made up three numbers in the range from 2 to 6,\nI will show you the sum and product of these numbers, your task is to guess them!");
            Random rnd = new Random();


            int value1 = rnd.Next(2, 7);
            int value2 = rnd.Next(2, 7);
            int value3 = rnd.Next(2, 7);


            var sum = value1 + value2 + value3;
            var product = value1 * value2 * value3;

            Console.WriteLine(sum + " - sum of three numbers");
            Console.WriteLine(product + " - product of three numbers");

            Console.WriteLine("Enter the desired numbers in the range from 2 to 6");
            int userValue1 = GetUserInput();
            int userValue2 = GetUserInput();
            int userValue3 = GetUserInput();


            var sumUser = userValue1 + userValue2 + userValue3;
            var productUser = userValue1 * userValue2 * userValue3;

            if (sumUser == sum && product == productUser)
            {
                Console.WriteLine("You won! The next level is waiting for you!");
                return true;
            }

            else
            {
                Console.WriteLine("No luck, try again");
                Console.WriteLine("1 number was made up - " + value1);
                Console.WriteLine("2 number was made up - " + value2);
                Console.WriteLine("3 number was made up - " + value3);


                return false;
            }
        }
        static bool Level4()
        {
            Console.WriteLine("Level 4");
            Console.WriteLine("RULES:\nI made up three numbers in the range from 2 to 7,\nI will show you the sum and product of these numbers, your task is to guess them!");
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

            if (sumUser == sum && product == productUser)
            {
                Console.WriteLine("You won! The next level is waiting for you!");
                return true;
            }

            else
            {
                Console.WriteLine("No luck, try again");
                Console.WriteLine("1 number was made up - " + value1);
                Console.WriteLine("2 number was made up - " + value2);
                Console.WriteLine("3 number was made up - " + value3);


                return false;
            }
        }
        static bool Level5()
        {
            Console.WriteLine("Level 5");
            Console.WriteLine("RULES:\nI made up three numbers in the range from 2 to 8,\nI will show you the sum and product of these numbers, your task is to guess them!");
            Random rnd = new Random();


            int value1 = rnd.Next(2, 9);
            int value2 = rnd.Next(2, 9);
            int value3 = rnd.Next(2, 9);


            var sum = value1 + value2 + value3;
            var product = value1 * value2 * value3;

            Console.WriteLine(sum + " - sum of three numbers");
            Console.WriteLine(product + " - product of three numbers");

            Console.WriteLine("Enter the desired numbers in the range from 2 to 8");
            int userValue1 = GetUserInput();
            int userValue2 = GetUserInput();
            int userValue3 = GetUserInput();


            var sumUser = userValue1 + userValue2 + userValue3;
            var productUser = userValue1 * userValue2 * userValue3;

            if (sumUser == sum && product == productUser)
            {
                Console.WriteLine("Unbelievable! You won the game! Congratulations!"); ;
                return true;
            }

            else
            {
                Console.WriteLine("No luck, try again");
                Console.WriteLine("1 number was made up - " + value1);
                Console.WriteLine("2 number was made up - " + value2);
                Console.WriteLine("3 number was made up - " + value3);


                return false;
            }
        }


    }
}
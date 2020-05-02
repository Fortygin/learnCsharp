using System;
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
            Console.WriteLine("Привет! Как тебя зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Привет " + name);
            Random rnd = new Random();


            int value1 = rnd.Next(2, 7);
            int value2 = rnd.Next(2, 7);
            int value3 = rnd.Next(2, 7);

            //Console.WriteLine(value1); 
            //Console.WriteLine(value2);
            //Console.WriteLine(value3);

            var sum = value1 + value2 + value3;
            var product = value1 * value2 * value3;

            Console.WriteLine(sum + " - сумма трех чисел");
            Console.WriteLine(product + " - произведение трех чисел");

            Console.ReadLine();
            int truCount = 1; //количество попыток угадывания
            int userValue1; //первое число которое вводит пользователь
            int userValue2;// второе число которое вводит пользователь
            int userValue3;//третье число которое вводит пользователь



            Console.WriteLine("Введите загаданные числа в диапозоне от 0 до 10");
            userValue1 = Convert.ToInt32(Console.ReadLine());
            userValue2 = Convert.ToInt32(Console.ReadLine());
            userValue3 = Convert.ToInt32(Console.ReadLine());


            Console.ReadKey();
        }
    }
}

using System;

namespace lab2ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ex 1: Scrieti un program care va afisa suma cifrelor unui numar n, n fiind
                citit de la tastatura. */
            
            Console.WriteLine("Insert a number:");

            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while(number > 0)
            {
                sum = sum + number % 10;
                number = number / 10;
            }
            Console.WriteLine("Sum of the entered digits is " + sum);
        }
    }
}

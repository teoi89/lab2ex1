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

            int x = int.Parse(Console.ReadLine());
            int y;
            int sum = 0;

            while(x > 0)
            {
                y = x % 10;
                sum = sum + y;
                x = x / 10;
            }
            Console.WriteLine("Sum of the entered digits is " + sum);
        }
    }
}

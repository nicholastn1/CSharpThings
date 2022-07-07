using System;
using System.Globalization.CultureInfo;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            // Show the Fibonacci sequence
            Console.WriteLine("Fibonacci sequence:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }

            // Show the factorial of a number
            Console.WriteLine("Factorial of 5:");
            Console.WriteLine(Factorial(5));

        }
    }
}

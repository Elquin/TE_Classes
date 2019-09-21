using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            string fibNumber = Console.ReadLine();
            int intFibNumber = int.Parse(fibNumber);

            for (int i = 0; i < intFibNumber; i++)
            {
                Console.WriteLine($"{(i + i)}");
            }
            Console.ReadLine();
        }
    }
}

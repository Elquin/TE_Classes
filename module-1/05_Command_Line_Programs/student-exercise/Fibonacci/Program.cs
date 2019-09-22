using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the Fibonacci number: ");
            int num = int.Parse(Console.ReadLine());

            int number1 = 0;
            int number2 = 1;
            int number3 = 1;

            Console.Write(number1 + " ");
            Console.Write(number2 + " ");

            while (number3 < num-number1)    
            {
                number3 = number1 + number2;
                Console.Write(number3 + " ");
                number1 = number2;
                number2 = number3;

            }
            Console.ReadLine();
        }
    }
}

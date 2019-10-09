using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        private static string GetFizzNumber(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            else if (number % 5 == 0 || number.ToString().Contains("5"))
            {
                return "Buzz";
            }
            else if (number % 3 == 0 || number.ToString().Contains("3"))
            {
                return "Fizz";
            }
            else
            {
                return number.ToString();
            }
        }

        static void Main(string[] args)
        {
            string outPath = "..\\..\\..\\..\\FizzBuzz.txt";
            using (StreamWriter sw = new StreamWriter(outPath))
            {
                for (int i = 1; i <= 300; i++)
                {
                    sw.WriteLine($"Result for number:{i} - {GetFizzNumber(i)}");
                }
                Console.WriteLine("FizzBuzz.txt has been created");
            }
            Console.ReadLine();
        }
    }
}

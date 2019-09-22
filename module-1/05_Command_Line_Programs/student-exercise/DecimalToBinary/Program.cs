using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in a series of decimal values (separated by spaces): ");
            string valuesString = Console.ReadLine();
            string[] values = valuesString.Split(" ");
            int i;

            for (i = 0; i < values.Length; i++)
            {
                int intValues = int.Parse(values[i]);
                Console.WriteLine(intValues / 2);
            }
            Console.ReadLine();
        }
    }
}

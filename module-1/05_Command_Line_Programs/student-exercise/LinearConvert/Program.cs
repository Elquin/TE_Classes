using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the length: ");
            string userlength = Console.ReadLine();
            Console.WriteLine("Is the measurement in (m)eter, or (f)eet? f: ");
            string meterOrFeet = Console.ReadLine();
            int intLength = int.Parse(userlength);

            if (meterOrFeet == "m" || meterOrFeet == "M")
            {
                Console.WriteLine($"{intLength}m is {intLength * 3.2808399}f.");
            }
            else if (meterOrFeet == "f" || meterOrFeet == "F")
            {
                Console.WriteLine($"{intLength}f is {intLength * 0.3048}m");
            }
            Console.ReadLine();
        }
    }
}

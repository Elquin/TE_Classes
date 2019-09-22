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
            int meter = (int)(intLength * 0.3048);
            int feet = (int)(intLength * 3.2808399);

            if (meterOrFeet == "m" || meterOrFeet == "M")
            {
                Console.WriteLine($"{intLength}m is {feet}f.");
            }
            else if (meterOrFeet == "f" || meterOrFeet == "F")
            {
                Console.WriteLine($"{intLength}f is {meter}m");
            }
            Console.ReadLine();
        }
    }
}

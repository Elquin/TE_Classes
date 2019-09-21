using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the temperature: ");
            string temperature = Console.ReadLine();
            Console.Write("Is the temperature in (C)elcius, or (F)arenheit? F? ");
            string celciusOrFarenheit = Console.ReadLine();
            int intTemperature = int.Parse(temperature);

            if ((celciusOrFarenheit == "C") || (celciusOrFarenheit == "c"))
            {
                Console.WriteLine($"{temperature}C is {(intTemperature * 1.8 + 32)}F");
            }
            else
            {
                Console.WriteLine($"{temperature}F is {(intTemperature - 32) / 1.8}C");
            }

            Console.ReadLine();
        }
    }
}

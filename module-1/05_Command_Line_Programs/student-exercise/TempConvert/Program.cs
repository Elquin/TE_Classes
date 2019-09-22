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
            int celcius = (int)((intTemperature - 32) / 1.8);
            int farenheit = (int)((intTemperature * 1.8 + 32));

            if ((celciusOrFarenheit == "C") || (celciusOrFarenheit == "c"))
            {
                Console.WriteLine($"{temperature}C is {farenheit}F");
            }
            else
            {
                Console.WriteLine($"{temperature}F is {celcius}C");
            }

            Console.ReadLine();
        }
    }
}

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
            int intVal = int.Parse(values[0]);
            int i;
            for (i = 0; i < values.Length; i++)
            {
                string strVal = ("");

                while (intVal != 0)
                {
                    strVal = ($"{intVal % 2}{strVal}");
                    intVal = intVal / 2;
                }

                Console.WriteLine(strVal);
                Console.ReadLine();
            }
        }
    }
}

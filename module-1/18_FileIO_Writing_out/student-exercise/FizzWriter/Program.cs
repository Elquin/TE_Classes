using System;
using System.IO;

namespace FizzWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string outPath = "..\\..\\..\\..\\FizzBuzz.txt";
            using (StreamWriter sw = new StreamWriter(outPath))
            {
                for (int i = 0; i <= 300; i++)
                {
                    sw.WriteLine();
                }
                
            }
        }
    }
}

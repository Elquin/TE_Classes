using System;
using System.IO;

namespace FileIO_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Output will go to this file
            string outPath = "..\\..\\..\\Folders.txt";

            try
            {
                using (StreamWriter sw = new StreamWriter(outPath, true))
                {
                    string spelunkingPath = "c:\\Git";
                    string[] dirs1 = Directory.GetDirectories(spelunkingPath);

                    sw.WriteLine($"Subfolders of {spelunkingPath} at {DateTime.UtcNow:f}:");

                    foreach (string subfolder in dirs1)
                    {
                        sw.WriteLine($"\t{subfolder}");
                    }


                }
            }
            catch (Exception e)
            {
                //Tell user there is a problem
                Console.WriteLine($"There was an ERROR: {e.Message}");
            }

            

            Console.WriteLine("Press RETURN");
            Console.ReadKey();
        }
    }
}

﻿using System;
using System.IO;

namespace WordSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //4. Loop through each line in the file
            //5. If the line contains the search string, print it out along with its line number

            try
            {
                //1. Ask the user for the search string
                Console.Write("Please enter a word to search: ");
                string wordInput = Console.ReadLine();
                //4. case sensitive?
                Console.WriteLine("Should the search be case sensitive? (Y/N)");
                string caseSensitive = Console.ReadLine();
                //2. Ask the user for the file path
                Console.WriteLine("Please enter the file path: ");
                string filePathInput = Console.ReadLine();

                //C:\Users\RHolland\git\robertholland-c\module-1\17_FileIO_Reading_in\student-exercise\alices_adventures_in_wonderland.txt
                //3. Open the file
                using (StreamReader stream = new StreamReader(filePathInput))
                {
                    int counter = 1; //Counter to keep track of current line.

                    while (!stream.EndOfStream)
                    {
                        string line = stream.ReadLine();
                        if (caseSensitive == "Y" || caseSensitive == "y")
                        {
                            if (line.Contains(wordInput))
                            {
                                Console.WriteLine($"{counter}) {line}");
                            }
                            counter++;
                        }
                        else if(caseSensitive == "N" || caseSensitive == "n")
                        {
                            if (line.Contains(wordInput, StringComparison.OrdinalIgnoreCase))
                            {
                                Console.WriteLine($"{counter}) {line}");
                            }
                            counter++;
                        }
                        else
                        {
                            Console.WriteLine("Incorrect selection.");
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Please enter a valid path.");
            }
            Console.ReadLine();
        }
    }
}

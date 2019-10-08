using System;

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
                //2. Ask the user for the file path
                Console.WriteLine("Please enter the file path: ");
                string input = Console.ReadLine();

                //C: \Users\RHolland\git\robertholland - c\module - 1\17_FileIO_Reading_in\student - exercise\alices_adventures_in_wonderland.txt
                //3. Open the file
                using (StreamReader stream = new StreamReader(input))
                {
                    int numberOfWords = 0;
                    int numberOfSentences = 0;
                    while (!stream.EndOfStream)
                    {
                        string wholeDoc = stream.ReadToEnd();
                        char[] delimiterChars = { '.', '!', '?' };
                        string[] wordsSplit = wholeDoc.Split(" ");
                        string[] sentenceSplit = wholeDoc.Split(delimiterChars);
                        numberOfWords += wordsSplit.Length;
                        numberOfSentences += sentenceSplit.Length;

                    }
                    Console.WriteLine($"Number of words equals: {numberOfWords}");
                    Console.WriteLine($"Number of sentences equals: {numberOfSentences}");
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

﻿using System;
using System.Collections.Generic;
namespace CollectionsLectureNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // LIST<T>
            //
            // Lists allow us to hold collections of data. They are declared with a type of data that they hold
            // only allowing items of that type to go inside of them.
            //
            // The syntax used for declaring a new list of type T is
            //      List<T> list = new List<T>();
            //
            //

            // Creating lists of integers
            List<int> numbers = new List<int>();


            // Creating lists of strings
            List<string> words = new List<string>() { "cat", "bat", "dragon", "apple" };

            Console.WriteLine(words);
            Console.WriteLine(string.Join(", ", words));

            /////////////////


            //////////////////
            // OBJECT EQUALITY
            //////////////////


            /////////////////
            // ADDING ITEMS
            /////////////////

            // Adding items one at a time to each list
            numbers.Add(100);
            numbers.Add(200);
            words.Add("zzz");
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine(string.Join(", ", words));
            words.Insert(3, "dd");
            Console.WriteLine(string.Join(", ", words));

            /////////////////
            // ADDING MULTIPLE ITEMS
            /////////////////

            int[] newNumbers = new int[] { 11, 22, 33, 44 };
            numbers.AddRange(newNumbers);
            Console.WriteLine(string.Join(", ", numbers));

            numbers.AddRange(new int[] { 99, 88 });
            Console.WriteLine(string.Join(", ", numbers));

            //////////////////
            // ACCESSING BY INDEX
            //////////////////

            Console.WriteLine(words[0]);
            words[0] = "alpha";
            Console.WriteLine(words[0]);


            ///////////////////
            // ACCESSING WITH FOR-EACH
            ///////////////////

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            int sum = 0;
            foreach (int n in numbers)
            {
                sum += n;
            }
            Console.WriteLine($"The sum is {sum}");

            ////////////////////
            // ADDITIONAL LIST<T> METHODS
            ////////////////////
            Console.WriteLine($"Does words contain alpha? { words.Contains("alpha")}");
            Console.WriteLine($"Does words contain alpha? { words.Contains("delta")}");



            ////////////////////////
            // SORT and PRINT A LIST
            ////////////////////////

            words.Sort();
            Console.WriteLine(string.Join(", ", words));
            words.Reverse();
            Console.WriteLine(string.Join(", ", words));
            // QUEUE <T>
            //
            // Queues are a special type of data structure that follow First-In First-Out (FIFO).
            // With Queues, we Enqueue (add) and Dequeue (remove) items.


            /////////////////////
            // PROCESSING ITEMS IN A QUEUE
            /////////////////////



            // STACK <T>
            //
            // Stacks are another type of data structure that follow Last-In First-Out (LIFO).
            // With Stacks, we Push (add) and Pop (remove) items. 


            ////////////////////
            // PUSHING ITEMS TO THE STACK
            //////////////////// 

            Stack<string> browserStack = new Stack<string>();
            browserStack.Push("Home Page");
            browserStack.Push("Login Page");
            browserStack.Push("Dashboard");

            Console.WriteLine(string.Join(", ", browserStack));

            string previousPage = browserStack.Pop();
            Console.WriteLine($"Previous page is {previousPage}");
            Console.WriteLine(string.Join(", ", browserStack));

            previousPage = browserStack.Peek();
            Console.WriteLine($"Previous page is {previousPage}");
            Console.WriteLine(string.Join(", ", browserStack));


            ////////////////////
            // POPPING THE STACK
            ////////////////////

            while (browserStack.Count > 0)  //loop to pop entire stack.
            {
                Console.WriteLine(browserStack.Pop());
            }
            Console.WriteLine(string.Join(", ", browserStack));

            Console.ReadLine();

        }
    }
}

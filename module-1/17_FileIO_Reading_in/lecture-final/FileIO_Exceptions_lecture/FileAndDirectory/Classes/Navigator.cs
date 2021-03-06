﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileAndDirectory.Classes
{
    public class Navigator
    {
        public void Run()
        {
            while (true)
            {
                string currentPath = Directory.GetCurrentDirectory();
                Console.Clear();

                Console.WriteLine("Windows Navigator");
                Console.WriteLine("-----------------");
                Console.WriteLine($"Current Directory: {currentPath}");
                Console.WriteLine();
                Console.WriteLine("1 - Navigate Directories");
                Console.WriteLine("2 - List Files");
                Console.WriteLine("3 - Read a file");
                Console.WriteLine("Q - Quit Navigator");

                switch (Console.ReadLine().Trim().ToLower())
                {
                    case "q":
                        return;
                    case "1":
                        NavigateDirectories();
                        break;
                    case "2":
                        ListFiles();
                        break;
                    case "3":
                        ReadFile();
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        private void NavigateDirectories()
        {
            while (true)
            {
                Console.Clear();

                // Get current and root directories here...
                string currentPath = Directory.GetCurrentDirectory();
                string root = Directory.GetDirectoryRoot(currentPath);
                bool hasParent = (currentPath != root);
                Console.WriteLine("Navigate Directories Submenu");
                Console.WriteLine("----------------------------");
                Console.WriteLine($"Current Directory: {currentPath}");
                Console.WriteLine();

                /// Get the list of dirs here...
                string[] dirs = Directory.GetDirectories(currentPath);


                if (hasParent)
                {
                    Console.WriteLine("0 - UP to Parent");
                }
                for (int i = 0; i < dirs.Length; i++)
                {

                    // Get the relative path here...
                    string relativePath = Path.GetRelativePath(currentPath, dirs[i]);

                    Console.WriteLine($"{i + 1} - {relativePath}");

                }
                Console.WriteLine("Q - Back to Navigator menu");

                string input = Console.ReadLine().Trim().ToLower();
                if (input == "q")
                {
                    break;
                }
                else if (input == "0" && hasParent)
                {
                    // Calculate parent folder here, and move there...

                    // This way works too!!
                    //DirectoryInfo di = Directory.GetParent(currentPath);
                    //Directory.SetCurrentDirectory(di.FullName);

                    Directory.SetCurrentDirectory("..");

                }
                else
                {
                    // Navigate to the folder at [selection - 1] here....
                        Console.WriteLine("Invalid selection. Please try again.");
                        Console.ReadLine();
                }
            }
        }

        private void ListFiles()
        {
            // List all the files in the current directory
            Console.Clear();

            // Get the current directory here...
            string currentPath = Directory.GetCurrentDirectory();
            Console.WriteLine("List Files Submenu");
            Console.WriteLine("------------------");
            Console.WriteLine($"Current Directory: {currentPath}");
            Console.WriteLine();

            // List all the files here....
            string[] files = Directory.GetFiles(currentPath);
            foreach (string file in files)
            {
                string relativePath = Path.GetRelativePath(currentPath, file);
                Console.WriteLine(relativePath);
            }


            Console.WriteLine();
            Console.WriteLine("Press RETURN to continue");
            Console.ReadLine();
        }

        private void ReadFile()
        {
            // List the files in the current dir and allow the user to select one.

        }


    }
}

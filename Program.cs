// Project for IT 2040
// Written by Cody Sloan
// 02/15/2019

using System;
using System.IO;

namespace Document
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // display name of file followed by a blank line
            Console.WriteLine("Document");
            Console.WriteLine("------------------");
            Console.ReadLine();

            // gather user input
            Console.WriteLine("Enter file name: ");
            string fileName = Console.ReadLine();
            if (string.IsNullOrEmpty(Path.GetExtension(fileName)))
            {
                fileName += ".txt";
            }
            Console.WriteLine("\n------------------");
            Console.WriteLine("Enter file contents: ");

            // write to text file
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };

            using (StreamWriter sw = new StreamWriter(fileName));
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            // display output to console
            Console.Write("\nFile Name: {0}", fileName + Environment.NewLine);
            Console.WriteLine("------------------");
            Console.WriteLine("------------------");
            Console.WriteLine("\nPress Enter to exit...");
            Console.ReadKey();
        }
    }
}

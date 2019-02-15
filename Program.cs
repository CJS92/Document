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

            // add .txt extension if one isn't given
            if (string.IsNullOrEmpty(Path.GetExtension(fileName)))
            {
                fileName += ".txt";
            }
            else
                {
                // continue execution
                }
            Console.WriteLine("\n------------------");
            Console.WriteLine("Enter file contents: ");
            string fileContents = Console.ReadLine();

            // open the file
            FileStream document;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                document = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(document);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: Unable to access {0}.");
                Console.WriteLine(e.Message);
                return;
            }

            // write to the file
            int characterCount = fileContents.Length;
            Console.SetOut(writer);
            Console.WriteLine("{0}", fileContents);
            Console.SetOut(oldOut);
            writer.Close();
            document.Close();
            Console.WriteLine("{0} was successfully saved. The document contains {1} characters.", fileName, characterCount);

            // do you want to write another document? (work in progress)
            //int newFile = Console.Read();
            //Console.WriteLine("Do you want to save another document?");
           //if (newFile) == 1
            //        { Console.WriteLine("test");
           // }


            // exit the program
            Console.WriteLine("Press Enter to exit...");
            Console.ReadLine();
        }
    }
}
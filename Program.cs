using System;
using static System.Console;
using static System.IO.File;

namespace SimpleFileIO
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Simple IO with the File Type *****\n");
            try
            {
                string[] myTasks = {
                  "Fix bathroom sink", "Call Dave",
                  "Call Mom and Dad", "Play Xbox 360"};

                // Write out all data to file on C drive.
                WriteAllLines(@"tasks.txt", myTasks);

                // Read it all back and print out.
                foreach (string task in ReadAllLines(@"tasks.txt"))
                {
                    WriteLine($"TODO: {task}");
                }
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
            ReadLine();
        }
    }

}
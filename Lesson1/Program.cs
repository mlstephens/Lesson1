using System;
using System.Collections.Generic;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //missing arguments?
            if (args.Length == 0)
            {
                Console.WriteLine("Missing command line arguments.\nValid command line example: Commandline arg1=test arg2=name");
            }

            //invalid value seperator?
            else if (!Array.TrueForAll(args, value => value.Contains("=")))
            {
                Console.WriteLine("Invalid command line argument value seperator.\nValid command line example: Commandline arg1=test arg2=name");
            }
            
            //we have arguments so display them
            else
            {
                CommandLineArguments commandLineArgs = new CommandLineArguments(args);
                Console.WriteLine($"Hello World - { commandLineArgs.FormatForDisplay()}");
            }
            
        }
    }
}

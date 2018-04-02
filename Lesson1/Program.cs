using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            //invalid arguments
            if (args.Length == 0 || !Array.TrueForAll(args, a => a.Split('=').Length == 2))
            {
                Console.WriteLine("Invalid command line arguments.\nValid command line example: Commandline arg1=test arg2=name");
            }

            //valid arguments
            else
            {
                CommandLineArguments commandLineArgs = new CommandLineArguments(args);
                Console.WriteLine($"Hello World - { commandLineArgs.FormatForDisplay() }");
            }
        }
    }
}

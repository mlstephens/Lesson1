using System;

namespace Lesson1
{
    class Program
    {
        private const string errorMessage = "Command Line Argument Error: valid command line example: Commandline arg1=test arg2=name";

        static void Main(string[] args)
        {
            CommandLineArguments commandLineArgs = new CommandLineArguments(args);

            Console.WriteLine(commandLineArgs.IsCommandLineValid
                ? commandLineArgs.FormatForDisplay()
                : errorMessage);            
        }
    }
}

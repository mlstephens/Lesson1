using System;

namespace Lesson1
{
    class Program
    {
        private const string errorMessage = "Command Line Argument Error: valid command line example: Commandline arg1=test arg2=name";

        static void Main(string[] args)
        {
            string message = string.Empty;
            CommandLineArguments commandLineArgs = new CommandLineArguments(args);

            Console.WriteLine(commandLineArgs.IsCommandLineValid
                ? commandLineArgs.FormatForDisplay()
                : errorMessage);            
        }
    }
}

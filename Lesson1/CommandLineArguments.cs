using System;
using System.Text;

namespace Lesson1
{
    public class CommandLineArguments
    {
        private string[] _arguments = null;

        public CommandLineArguments(string[] commandLineArguments)
        {
            _arguments = commandLineArguments;
        }

        public string FormatForDisplay()
        {
            StringBuilder formattedArgs = new StringBuilder();

            foreach (string argument in _arguments)
            {
                string[] parsedArg = argument.Split('=');

                //valid argument structure
                if (parsedArg.Length == 2)
                {
                    formattedArgs.Append($"[{parsedArg[0].Trim()} - {parsedArg[1].Trim()}] ");                    
                }

                //invalid argument structure
                else
                {
                    formattedArgs.Append("[invalid argument] ");
                }
            }
            return formattedArgs.ToString();
        }

    }
}

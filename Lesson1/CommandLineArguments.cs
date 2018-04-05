using System;
using System.Linq;
using System.Text;

namespace Lesson1
{
    public class CommandLineArguments
    {
        private string[] _argArray = null;
        private const char _argSeperator = '=';

        public CommandLineArguments(string[] clArgArray)
        {
            _argArray = clArgArray;
        }
        
        public bool IsCommandLineValid { get => _argArray.Any() && !_argArray.Any(a => a.Split(_argSeperator).Length != 2); }

        public string FormatForDisplay()
        {
            StringBuilder formattedArgs = new StringBuilder();

            formattedArgs.Append("Hello World - ");

            foreach (string argument in _argArray)
            {
                string[] parsedArg = argument.Split(_argSeperator);
                formattedArgs.Append($"[{parsedArg[0].Trim()} - {parsedArg[1].Trim()}] ");
            }
            return formattedArgs.ToString();
        }
    }
}

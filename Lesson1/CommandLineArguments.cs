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
                if (parsedArg.Length > 0)
                {
                    //invalid argument structure?
                    if (parsedArg.Length != 2)
                    {
                        formattedArgs.Append("[invalid argument] ");
                    }
                    else
                    {
                        formattedArgs.Append($"[{parsedArg[0].Trim()} - {parsedArg[1].Trim()}] ");
                    }
                }
            }
            return formattedArgs.ToString();
        }

    }
}

﻿using System;
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

        private bool ArrayIsEmpty { get { return !_argArray.Any(); } }

        private bool HaveInvalidArguments { get { return _argArray.Any(a => a.Split(_argSeperator).Length != 2); } }

        public bool IsCommandLineValid { get { return (ArrayIsEmpty || HaveInvalidArguments) ? false : true; } }        

        public string FormatForDisplay()
        {
            StringBuilder formattedArgs = new StringBuilder();

            foreach (string argument in _argArray)
            {
                string[] parsedArg = argument.Split(_argSeperator);
                formattedArgs.Append($"[{parsedArg[0].Trim()} - {parsedArg[1].Trim()}] ");
            }
            return formattedArgs.ToString();
        }
    }
}

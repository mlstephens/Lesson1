using System;
using System.Collections.Generic;

namespace Lesson1
{
    class Program
    {
        class InputValues
        {
            public string Line { get; set; }
            public string InputValue { get; set; }
        }
        static void Main(string[] args)
        {
            string userInput = string.Empty;
            int inputCounter = 1;
            bool quitFlag = false;
            List<InputValues> inputList = new List<InputValues>();

            Console.WriteLine("Please enter anything you wish to or 'Q' to quit.");
            userInput = Console.ReadLine();

            while (!quitFlag)
            {
                if (userInput.ToUpper() == "Q")
                {
                    quitFlag = true;
                }
                else
                {
                    InputValues newInput = new InputValues() { Line = inputCounter.ToString(), InputValue = userInput };
                    inputList.Add(newInput);
                    inputCounter++;

                    userInput = Console.ReadLine();
                }
            }            

            Console.Write("Hello World\n");

            foreach (InputValues inputValue in inputList)
            {
                Console.WriteLine($"Line: { inputValue.Line } - Value: { inputValue.InputValue }.");
            }
        }        
    }
}

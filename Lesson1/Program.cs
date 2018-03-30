using System;
using System.Collections.Generic;

namespace Lesson1
{
    class Program
    {
        class ConsoleInput
        {
            public string Id { get; set; }
            public string Value { get; set; }
        }
        static void Main(string[] args)
        {
            string valueInput = string.Empty;
            int inputCounter = 1;
            bool quitFlag = false;
            
            List<ConsoleInput> consoleInputs = new List<ConsoleInput>();

            Console.WriteLine("Please enter a list of items each followed by the Enter key or 'Q' to quit entering and display your list.");
            valueInput = Console.ReadLine();

            while (!quitFlag)
            {
                //user done entering?
                if (valueInput.ToUpper() == "Q")
                {
                    quitFlag = true;
                }
                else
                {
                    //creating object
                    ConsoleInput consoleInput = new ConsoleInput() { Id = inputCounter.ToString(), Value = valueInput };

                    //add to list
                    consoleInputs.Add(consoleInput);

                    //increment line counter
                    inputCounter++;

                    //get next line
                    valueInput = Console.ReadLine();
                }
            }

            //display list to window
            Console.Write("\n\rHello World\n");
            foreach (ConsoleInput consoleInput in consoleInputs)
            {

                Console.WriteLine($"Item: { consoleInput.Id } - Value: { consoleInput.Value }.");
            }
        } 
    }
}

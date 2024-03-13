using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        bool continueDisplay = true;

        while (continueDisplay)
        {
            Console.Clear();
            scripture.Display();
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                continueDisplay = false;
            }
            else
            {
                continueDisplay = scripture.HideRandomWord();
            }
        }
    }
}
       
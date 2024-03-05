using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        string[] prompts = {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
        Random rnd = new Random();

        Console.WriteLine("Welcome to the journal Program!");
        
        while (true)
        {
            Console.WriteLine("Please select one of the followong options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Which option do you choose? ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string randomPrompt = prompts[rnd.Next(prompts.Length)];
                    Console.WriteLine("Prompt: " + randomPrompt);
                    Console.WriteLine("Enter your response:");
                    string response = Console.ReadLine();
                    string currentDate = DateTime.Now.ToString("MM/dd/yyyy");
                    journal.AddEntry(randomPrompt, response, currentDate);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                      Console.Write("Enter the filename to load: ");
                    string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break; 
                case "5":
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
                      }
        }
    }
}

    

            
        
    




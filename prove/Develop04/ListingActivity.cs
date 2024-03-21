using System;
using System.Collections.Generic;
using System.Threading;

class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void Start()
    {
        CommonStartingMessage("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        DisplaySpinner(8); // Spinner animation for 2 seconds (8 iterations)

        Console.WriteLine("Begin listing items...");
        Thread.Sleep(3000); // Pause for 3 seconds to begin listing

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(durationInSeconds);

        int itemCount = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write("You may begin in: \n");
            string item = Console.ReadLine();
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items!");

        CommonEndingMessage("Listing Activity");
    }
}

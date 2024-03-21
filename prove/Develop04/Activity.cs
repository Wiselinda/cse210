using System;
using System.Collections.Generic;
using System.Threading;

class Activity
{
    protected int durationInSeconds;

    protected void CommonStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"Welcome to the {activityName}...\n");
        Console.WriteLine(description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session?: ");
        durationInSeconds = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected void CommonEndingMessage(string activityName)
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed the {activityName}.");
        Console.WriteLine($"Duration: {durationInSeconds} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
        Console.WriteLine();
    }

    // Spinner animation method
    protected void DisplaySpinner(int duration)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int counter = 0;
        for (int i = 0; i < duration; i++)
        {
            Console.Write(spinner[counter % 4] + "\b");
            Thread.Sleep(250); // Adjust speed of spinner animation (milliseconds)
            counter++;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Threading;

class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void Start()
    {
        CommonStartingMessage("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        DisplaySpinner(8); // Spinner animation for 2 seconds (8 iterations)

        foreach (string question in questions)
        {
            Console.WriteLine(question);
            DisplaySpinner(8); // Spinner animation for 2 seconds (8 iterations)
        }

        int remainingSeconds = durationInSeconds - questions.Length - 2; // Subtracting time for prompts and questions

        // Countdown timer
        for (int i = remainingSeconds; i > 0; i--)
        {
            Console.WriteLine($"Remaining time: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }

        CommonEndingMessage("Reflection Activity");
    }
}
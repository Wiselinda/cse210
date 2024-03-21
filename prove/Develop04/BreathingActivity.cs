using System;
using System.Threading;

class BreathingActivity : Activity
{
    public void Start()
    {
        CommonStartingMessage("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        Console.WriteLine("Breathe in...");
        DisplaySpinner(8); // Spinner animation for 2 seconds (8 iterations)
        Console.WriteLine("Now breathe out...");
        DisplaySpinner(8); // Spinner animation for 2 seconds (8 iterations)

        int remainingSeconds = durationInSeconds - 4; // Subtracting 4 seconds for the breathing intervals

        // Countdown timer
        for (int i = remainingSeconds; i > 0; i--)
        {
            Console.WriteLine($"Remaining time: {i} seconds");
            Thread.Sleep(1000); // Pause for 1 second
        }

        CommonEndingMessage("Breathing Activity");
    }
}
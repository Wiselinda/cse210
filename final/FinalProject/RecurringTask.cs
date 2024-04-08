using System;
using System.Collections.Generic;



public class RecurringTask : Task
{
    public int Frequency { get; private set; }

    public RecurringTask(string title, DateTime dueDate, int frequency) : base(title, dueDate)
    {
        Frequency = frequency;
    }

    public override void Display()
    {
        Console.WriteLine($"Recurring Task: {Title}, Due Date: {DueDate}, Frequency: {Frequency} days, Completed: {IsCompleted}");
    }
}
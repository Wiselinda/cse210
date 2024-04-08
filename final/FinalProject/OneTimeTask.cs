using System;
using System.Collections.Generic;


public class OneTimeTask : Task
{
    public OneTimeTask(string title, DateTime dueDate) : base(title, dueDate)
    {
    }

    public override void Display()
    {
        Console.WriteLine($"One-time Task: {Title}, Due Date: {DueDate}, Completed: {IsCompleted}");
    }
}
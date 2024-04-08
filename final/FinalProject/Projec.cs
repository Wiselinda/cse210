using System;
using System.Collections.Generic;


public class Project : Task
{
    public List<Task> Subtasks { get; private set; }

    public Project(string title, DateTime dueDate, List<Task> subtasks) : base(title, dueDate)
    {
        Subtasks = subtasks;
    }

    public override void Display()
    {
        Console.WriteLine($"Project: {Title}, Due Date: {DueDate}, Completed: {IsCompleted}");
        foreach (var subtask in Subtasks)
        {
            Console.WriteLine("\tSubtask:");
            subtask.Display();
        }
    }
}

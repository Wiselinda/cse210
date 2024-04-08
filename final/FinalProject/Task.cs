using System;
using System.Collections.Generic;

public abstract class Task
{
    public string Title { get; protected set; }
    public DateTime DueDate { get; protected set; }
    public bool IsCompleted { get; set; } 

    public Task(string title, DateTime dueDate)
    {
        Title = title;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public abstract void Display();
}




        
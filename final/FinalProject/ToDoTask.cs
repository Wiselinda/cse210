using System;
using System.Collections.Generic;

class ToDoTask
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public ToDoTask(string title, string description, DateTime dueDate)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
    }
}

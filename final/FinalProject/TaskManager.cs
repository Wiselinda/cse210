using System;
using System.Collections.Generic;


public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
        Console.WriteLine($"Task '{task.Title}' added.");
    }

    public void ListTasks()
    {
        Console.WriteLine("\n--- Tasks ---");
        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i].Title}");
        }
    }

    public void DisplayTaskDetails(int taskIndex)
    {
        if (taskIndex >= 1 && taskIndex <= tasks.Count)
        {
            Task selectedTask = tasks[taskIndex - 1];
            Console.WriteLine("\n--- Task Details ---");
            selectedTask.Display();
            if (selectedTask is Project project)
            {
                Console.WriteLine("\n--- One-time Tasks ---");
                foreach (var subtask in project.Subtasks)
                {
                    if (subtask is OneTimeTask oneTimeTask)
                    {
                        oneTimeTask.Display();
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid task index.");
        }
    }

    public void MarkTaskAsCompleted(string title)
    {
        Task task = tasks.Find(t => t.Title == title);
        if (task != null)
        {
            task.IsCompleted = true;
            Console.WriteLine($"Task '{title}' marked as completed.");
        }
        else
        {
            Console.WriteLine($"Task '{title}' not found.");
        }
    }
}
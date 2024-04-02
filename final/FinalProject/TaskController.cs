using System;
using System.Collections.Generic;

class TaskController
{
    private List<ToDoTask> taskList;

    public TaskController()
    {
        taskList = new List<ToDoTask>();
    }

    public void CreateTask(string title, string description, DateTime dueDate)
    {
        ToDoTask newTask = new ToDoTask(title, description, dueDate);
        taskList.Add(newTask);
        Console.WriteLine("Task created successfully!");
    }

    public void DeleteTask(int index)
    {
        if (index >= 0 && index < taskList.Count)
        {
            taskList.RemoveAt(index);
            Console.WriteLine("Task deleted successfully!");
        }
        else
        {
            Console.WriteLine("Invalid task index!");
        }
    }

    public void ViewTaskList()
    {
        Console.WriteLine("Task List:");
        for (int i = 0; i < taskList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {taskList[i].Title} - {taskList[i].DueDate}");
        }
    }
}
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TaskController taskController = new TaskController();

        
        taskController.CreateTask("Open-ended Project", "Creating, Viewing, Deleting Task", DateTime.Now.AddDays(7));
        taskController.ViewTaskList();
        taskController.DeleteTask(0);
        taskController.ViewTaskList();
    }
}
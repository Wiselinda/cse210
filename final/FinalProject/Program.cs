using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome to the Time Management Application!");
        Console.WriteLine("You can manage your tasks efficiently here.");

        TaskManager taskManager = new TaskManager();

        taskManager.AddTask(new OneTimeTask("Finish web development project", DateTime.Now.AddDays(7)));
        taskManager.AddTask(new OneTimeTask("Visit psychiatrist", DateTime.Now.AddDays(10)));
        taskManager.AddTask(new RecurringTask("Exercise", DateTime.Now, 1));
        taskManager.AddTask(new OneTimeTask("Talk with mom", DateTime.Now.AddDays(2)));
        taskManager.AddTask(new OneTimeTask("Take care of cat", DateTime.Now));

        bool continueViewingTasks = true;

        do
        {
            taskManager.ListTasks();

            Console.Write("\nEnter the number of the task you want to view (or 0 to exit): ");
            if (int.TryParse(Console.ReadLine(), out int selectedTaskIndex))
            {
                if (selectedTaskIndex == 0)
                {
                    continueViewingTasks = false;
                }
                else
                {
                    taskManager.DisplayTaskDetails(selectedTaskIndex);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        } while (continueViewingTasks);

        Console.WriteLine("\nThank you for using the Time Management Application. Goodbye!");
    }
}



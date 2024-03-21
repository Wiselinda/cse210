using System;
using System.Collections.Generic;
using System.Threading;

class Menu
{
    public void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing Activity");
            Console.WriteLine("2. Start reflection Activity");
            Console.WriteLine("3. Start listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}

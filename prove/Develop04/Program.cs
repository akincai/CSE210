using System;

// EXCEEDS REQUIREMENTS:
// Ensures random questions are not repeated in ReflectingActivity.cs
/* Static member variables for each child Activity class allow the 
    parent class to be initialized without constructor parameters in the child class*/

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Choose from the following options:");
            Console.WriteLine("1) Breathing Activity");
            Console.WriteLine("2) Reflecting Activity");
            Console.WriteLine("3) Listing Activity");
            Console.WriteLine("4) Quit");
            Console.Write(">> ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity ra = new ReflectingActivity();
                ra.Run();
            }
            else if (choice == "3")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Quitting Program...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection. Please choose from options 1-4.");
            }
        }
    }
}
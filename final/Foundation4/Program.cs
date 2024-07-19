using System;
using System.Security.Principal;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity> {
            new RunningActivity(30, 4.8f),
            new RunningActivity(45, 6),
            new CyclingActivity(30, 15),
            new CyclingActivity(45, 12),
            new SwimmingActivity(30, 28),
            new SwimmingActivity(45, 38)
        };

        foreach(Activity a in activities)
            Console.WriteLine(a.GetSummary());
        
    }
}
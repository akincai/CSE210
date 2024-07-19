using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent e1 = new LectureEvent("How to Spend Frugally", "A walk through the ways to prevent expensive habits", 
        "8/12/2024", "2:00PM", "123 Spenda Way", "James Penny", 120);
        ReceptionEvent e2 = new ReceptionEvent("Peter's Birthday", "A get-together for Peter Markey's birthday party", 
        "9/22/2024", "12:00PM", "4 Celebration Lane", "peters.mom@hotmail.com");
        OutdoorEvent e3 = new OutdoorEvent("Halloween Scare Fest", "A spooky experience catered to those who enjoy being frightened", 
        "10/31/2024", "6:30PM", "62 Spooky Court", "96% Chance of Rain");

        e1.DisplayShortDetails();
        Console.WriteLine();
        e1.DisplayStandardDetails();
        Console.WriteLine();
        e1.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine();

        e2.DisplayShortDetails();
        Console.WriteLine();
        e2.DisplayStandardDetails();
        Console.WriteLine();
        e2.DisplayFullDetails();
        Console.WriteLine();
        Console.WriteLine();

        e3.DisplayShortDetails();
        Console.WriteLine();
        e3.DisplayStandardDetails();
        Console.WriteLine();
        e3.DisplayFullDetails();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your letter percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        string letter = "";

        if (percentage >= 90)
            letter = "A";
        else if (percentage >= 80)
            letter = "B";
        else if (percentage >= 70)
            letter = "C";
        else if (percentage >= 60)
            letter = "D";
        else
            letter = "F";
        
        Console.WriteLine($"Your grade is: {letter}");
        if (percentage >= 70)
            Console.WriteLine("Way to go! You passed!");
        else
            Console.WriteLine("You didn't pass, but you've got it next time!");
    }
}
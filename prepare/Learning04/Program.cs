using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Samuel Bennet", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        MathAssignment ma1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(ma1.GetSummary());
        Console.WriteLine(ma1.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment wa1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(wa1.GetSummary());
        Console.WriteLine(wa1.GetWritingInformation());
        Console.WriteLine();
    }
}
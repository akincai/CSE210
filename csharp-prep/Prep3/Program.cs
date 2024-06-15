using System;

class Program
{
    static void Main(string[] args)
    {
        int number = new Random().Next(1, 100);

        // initialize guess as -1 as it is outside the range of random numbers and cannot match the number before the loop runs
        int guess = -1;
        while(guess != number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
                Console.WriteLine("Higher");
            else if (number < guess)
                Console.WriteLine("Lower");
            else
                Console.WriteLine("You guessed it!");
        }
    }
}
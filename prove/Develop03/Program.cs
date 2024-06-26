using System;

// EXCEEDS REQUIREMENTS:
// Tracks which words have been hidden in Scriptures.cs using _shownIndexes list


class Program
{
    static void Main(string[] args)
    {
        string text = "For every high priest taken from among men is ordained for men in things pertaining to God, that he may offer both gifts and sacrifices for sins: Who can have compassion on the ignorant, and on them that are out of the way; for that he himself also is compassed with infirmity. And by reason hereof he ought, as for the people, so also for himself, to offer for sins.";
        Reference refe = new Reference("Hebrews", 5, 1, 3);
        Scripture myScripture = new Scripture(refe, text);
        
        while (true)
        {
            if (myScripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(myScripture.GetDisplayText());
                break;
            }
            Console.Clear();
            Console.WriteLine(myScripture.GetDisplayText());
            
            Console.WriteLine();
            Console.WriteLine("Type \"quit\" to exit or press enter to hide a word.");

            Console.Write(">> ");
            string choice = Console.ReadLine();
            if (choice == "quit")
                break;
            
            myScripture.HideRandomWords(1);
            Console.WriteLine();
        }
    }
}
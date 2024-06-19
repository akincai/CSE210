using System;
using System.Security.AccessControl;
using System.Xml.Linq;

// Exceeds core requirements:
// added a check to make sure current journal loaded in is saved

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator pg = new PromptGenerator();
        Journal myJournal = new Journal();
        
        bool isSaved = true;

        while(true)
        {
            Console.WriteLine("Select from the following options:");
            Console.WriteLine("1: Write a new Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal");
            Console.WriteLine("4: Load Custom Journal");
            Console.WriteLine("5: Quit Program");
            Console.Write    (">> ");
            string choice = Console.ReadLine();
            

            // new entry
            if (choice == "1")
            {
                // new entry is unsaved
                isSaved = false;

                Entry newEntry = new Entry();
                newEntry._promptText = pg.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);
                Console.Write(">> ");
                newEntry._entryText = Console.ReadLine();
                newEntry._date = DateTime.Today.ToString("d");

                myJournal.AddEntry(newEntry);

            }
            // display journal
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            // save journal
            else if (choice == "3")
            {
                Console.WriteLine("Enter the filename to save to the journal to (end in .txt)");
                Console.Write(">> ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);

                // update isSaved status
                isSaved = true;
            }
            // load journal
            else if (choice == "4")
            {
                if (!isSaved)
                {
                    Console.WriteLine("Current journal has not been saved! Enter C to continue loading.");
                    Console.Write(">> ");
                    string quitChoice = Console.ReadLine();
                    if (quitChoice != "c" && quitChoice != "C")
                        continue;
                }

                // clear journal data
                myJournal = new Journal();

                // new journal indicates no new entries
                isSaved = true;

                Console.WriteLine("Enter the filename of the journal (with .txt)");
                Console.Write(">> ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                if (!isSaved)
                {
                    Console.WriteLine("Current journal has not been saved! Enter Q to confirm quit.");
                    Console.Write(">> ");
                    string quitChoice = Console.ReadLine();
                    if (quitChoice != "q" && quitChoice != "Q")
                        continue;
                }
                Console.WriteLine("Quitting program.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
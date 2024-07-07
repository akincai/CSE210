public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    // maintaining static variables to initialize parent class
    private static string defName = "Listing";
    private static string defDescription = "This activity will help you reflect on the good things in your life " + 
    "by having you list as many things as you can in a certain area.";
    private static int defDuration = 0;

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        InitializeLists();
        _count = 0;
    }

    public ListingActivity() : base(defName, defDescription, defDuration)
    {
        InitializeLists();
        _count = 0;
    }


    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Please enter a duration, in seconds, for the activity.");
        Console.Write(">> ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("List as many responses you can to the following prompt:");
        GetRandomPrompt();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        while(DateTime.Now < end)
        {
            // removed GetListFromUser() method because of the issue of asynchronously running with timer boolean checks
            Console.Write(">> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!\n");
        
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }

    public void GetRandomPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count())];
        _prompts.Remove(prompt);
        Console.WriteLine($" --- {prompt} --- ");
    }

    public void InitializeLists()
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
}
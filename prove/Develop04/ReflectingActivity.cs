public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    // maintaining static variables to initialize parent class
    private static string defName = "Reflecting";
    private static string defDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. " + 
    "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private static int defDuration = 0;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        InitializeLists();
    }

    public ReflectingActivity() : base(defName, defDescription, defDuration)
    {
        InitializeLists();
    }


    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();

        Console.WriteLine("Please enter a duration, in seconds, for the activity.");
        Console.Write(">> ");
        SetDuration(int.Parse(Console.ReadLine()));

        Console.Clear();


        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine();
        
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        DisplayPrompt();
        Console.WriteLine();
        
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        Console.Clear();

        do
        {
            if (_questions.Count == 0)
            {
                Console.Write("End of Questions. Exiting... ");
                ShowSpinner(3);
                Console.WriteLine();
                break;
            }
            DisplayQuestions();
        }while(DateTime.Now < endTime);

        Console.WriteLine("Well done!");
        ShowSpinner(5);
        Console.WriteLine();

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }

    public string GetRandomPrompt()
    {
        string prompt = _prompts[new Random().Next(_prompts.Count())];
        _prompts.Remove(prompt);
        return prompt;
    }

    public string GetRandomQuestion()
    {
        string question = _questions[new Random().Next(_questions.Count())];
        // removes instance from list to ensure no repeat questions are accessed until a new instance is created
        _questions.Remove(question);
        return question;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
    }

    public void DisplayQuestions()
    {
        for (int i = 0; i < 2; i++)
        {
            if (_questions.Count == 0)
                break;
            Console.Write($"{GetRandomQuestion()} ");
            ShowSpinner(5);
            Console.WriteLine();
        }
    }

    public void InitializeLists()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }
}
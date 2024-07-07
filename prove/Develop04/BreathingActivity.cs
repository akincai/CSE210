public class BreathingActivity : Activity
{
    // maintaining static variables to initialize parent class
    private static string defName = "Breathing";
    private static string defDescription = "This activity will help you relax by walking through your breathing in and out slowly. " + 
        "Clear your mind and focus on your breathing.";
    private static int defDuration = 0;

    public BreathingActivity(string name, string description, int duration) : base(name, description, duration) {}

    public BreathingActivity() : base(defName, defDescription, defDuration) {}


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
        Console.WriteLine();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());
        while(DateTime.Now < end)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out...");
            ShowCountDown(6);
            Console.WriteLine();

            Console.WriteLine();
        }
        
        Console.WriteLine("Well done!");
        ShowSpinner(5);

        DisplayEndingMessage();
        ShowSpinner(5);

        Console.Clear();
    }
}
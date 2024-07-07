public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    private List<string> _spinnerList;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;

        _spinnerList = new List<string> {"|","/","-","\\"};
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
    }

    public void ShowSpinner(int seconds)
    {
        // determines the number of frames (iterations) are shown per second
        int fps = 10;
        for (int i = 0; i < seconds*fps; i++)
        {
            Console.Write(_spinnerList[i%_spinnerList.Count]);
            Thread.Sleep(1000/fps);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);

            Thread.Sleep(1000);

            for(int j = 0; j < i.ToString().Length; j++)
                Console.Write("\b \b");
        }
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }
    public int GetDuration()
    {
        return _duration;
    }
}
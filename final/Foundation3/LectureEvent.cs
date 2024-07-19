public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;

    public LectureEvent(string title, string desc, string date, string time, string address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }
}
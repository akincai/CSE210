public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string title, string desc, string date, string time, string address)
    {
        _title = title;
        _description = desc;
        _date = date;
        _time = time;
        _address = address;
    }


    public void DisplayStandardDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
    }

    public void DisplayShortDetails()
    {
        string type = GetType().ToString();
        Console.WriteLine($"Type of Event: {type.Substring(0,type.Length-5)} {type.Substring(type.Length-5)}");
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Date: {_date}");
    }
}
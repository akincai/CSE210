public class ReceptionEvent : Event
{
    private string _email;

    public ReceptionEvent(string title, string desc, string date, string time, string address, string email) : base(title, desc, date, time, address)
    {
        _email = email;
    }

    
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Email: {_email}");
    }
}
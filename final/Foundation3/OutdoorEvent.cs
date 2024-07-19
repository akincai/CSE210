public class OutdoorEvent : Event
{
    private string _forecast;

    public OutdoorEvent(string title, string desc, string date, string time, string address, string forecast) : base(title, desc, date, time, address)
    {
        _forecast = forecast;
    }

    
    public void DisplayFullDetails()
    {
        DisplayStandardDetails();
        Console.WriteLine($"Forecast: {_forecast}");
    }
}
public abstract class Activity
{
    protected DateTime _date;
    protected int _length;

    public Activity(int length)
    {
        _date = DateTime.Now;
        _length = length;
    }


    public abstract float CalculateDistance();

    public abstract float CalculateSpeed();

    public float CalculatePace()
    {
        return 60 / CalculateSpeed();
    }

    public string GetSummary()
    {
        return $"{_date.ToString("d MMM yyyy")} ({_length} min): Distance: {CalculateDistance()} km, " + 
                $"Speed: {CalculateSpeed()} kph, Pace: {CalculatePace()} min per km";
    }
}
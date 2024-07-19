public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(int length, int laps) : base(length)
    {
        _laps = laps;
    }


    public override float CalculateDistance()
    {
        return (float)_laps * 50 / 1000;
    }

    public override float CalculateSpeed()
    {
        return CalculateDistance() / _length * 60;
    }
}
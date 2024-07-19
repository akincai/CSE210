public class RunningActivity : Activity
{
    private float _distance;

    public RunningActivity(int length, float distance) : base(length)
    {
        _distance = distance;
    }


    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed()
    {
        return _distance / _length * 60;
    }
}
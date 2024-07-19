public class CyclingActivity : Activity
{
    private float _speed;

    public CyclingActivity(int length, float speed) : base(length)
    {
        _speed = speed;
    }


    public override float CalculateDistance()
    {
        return _speed * _length;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }
}
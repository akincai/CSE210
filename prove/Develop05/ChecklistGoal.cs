public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;

        _amountCompleted = 0;
    }


    public override int RecordEvent()
    {
        _amountCompleted++;
        // only award bonus when the target is initially reached
        if (_amountCompleted == _target)
            return _points+_bonus;
        else
            return _points;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        else
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetType()}~{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}
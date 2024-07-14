using System.Runtime.CompilerServices;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }


    public void Start()
    {
        while(true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1) Create a New Goal");
            Console.WriteLine("2) List Goals");
            Console.WriteLine("3) Save Goals");
            Console.WriteLine("4) Load Goals");
            Console.WriteLine("5) Record Event");
            Console.WriteLine("6) Quit");

            Console.Write(">> ");
            string choice = Console.ReadLine();

            if (choice == "1")
                CreateGoal();
            else if (choice == "2")
                ListGoalDetails();
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename for the goal file?");
                Console.Write(">> ");
                SaveGoals(Console.ReadLine());
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename for the goal file?");
                Console.Write(">> ");
                LoadGoals(Console.ReadLine());
            }
            else if (choice == "5")
                RecordEvent();
            else if (choice == "6")
                break;
            else
                Console.WriteLine("Please enter a valid option.");
            
            Console.WriteLine();

        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];
            Console.WriteLine($"{i+1}. {g.GetName()}");
        }
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal g = _goals[i];
            Console.WriteLine($"{i+1}. {g.GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1) Simple Goal");
        Console.WriteLine("2) Eternal Goal");
        Console.WriteLine("3) Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create?");
        Console.Write(">> ");
        string goalType = Console.ReadLine();

        if (goalType == "1")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">> ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">> ");
            string desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            Console.Write(">> ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (goalType == "2")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">> ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">> ");
            string desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            Console.Write(">> ");
            int points = int.Parse(Console.ReadLine());

            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (goalType == "3")
        {
            Console.WriteLine("What is the name of your goal?");
            Console.Write(">> ");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            Console.Write(">> ");
            string desc = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            Console.Write(">> ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            Console.Write(">> ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            Console.Write(">> ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
        else
        {
            Console.WriteLine("Invalid Goal Type.");
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish?");
        Console.Write(">> ");
        int accomplished = int.Parse(Console.ReadLine());
        int earned = _goals[accomplished-1].RecordEvent();
        Console.WriteLine($"Congratulations! You have earned {earned} points");
        _score += earned;
    }

    public void SaveGoals(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            outputFile.WriteLine(_score);
            foreach (Goal g in _goals)
            {
                outputFile.WriteLine(g.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        _goals = new List<Goal>();

        _score = int.Parse(lines[0]);


        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            int separatorInd = line.IndexOf("~");
            string type = line.Substring(0, separatorInd);
            string data = line.Substring(separatorInd+1);
            string[] parts = data.Split("|");

            if (type == "SimpleGoal")
            {
                string name = parts[0];
                string desc = parts[1];
                int points = int.Parse(parts[2]);
                bool isComplete = bool.Parse(parts[3]);

                SimpleGoal sg = new SimpleGoal(name, desc, points);
                if (isComplete)
                    sg.RecordEvent();
                
                _goals.Add(sg);
            }
            else if (type == "EternalGoal")
            {
                string name = parts[0];
                string desc = parts[1];
                int points = int.Parse(parts[2]);
                
                EternalGoal eg = new EternalGoal(name, desc, points);

                _goals.Add(eg);
            }
            else if (type == "ChecklistGoal")
            {
                string name = parts[0];
                string desc = parts[1];
                int points = int.Parse(parts[2]);
                int bonus = int.Parse(parts[3]);
                int target = int.Parse(parts[4]);
                int amountCompleted = int.Parse(parts[5]);

                ChecklistGoal cg = new ChecklistGoal(name, desc, points, target, bonus);

                for (int j = 0; j < amountCompleted; j++)
                    cg.RecordEvent();

                _goals.Add(cg);
            }
        }
    }
}
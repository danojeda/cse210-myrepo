using System.Diagnostics.Contracts;

public class SimpleGoal:Goal
{
    private bool _isComplete;


    public SimpleGoal(string name, string description, string points ):base (name,description,points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations, you have earned {GetPoints()} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string  GetStringRepresentation()
    {
        return "SimpleGoal|"+ GetName() +"|"+GetDescription() +"|"+GetPoints()+"|"+Convert.ToString(_isComplete);
    }
}
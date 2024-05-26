
using System.Runtime.CompilerServices;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public  ChecklistGoal(string name, string description, string points, int target, int bonus):base (name,description,points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
      //  return _isCompleted;
    }

    public override bool IsComplete()
    {
        return true;
    } 


    public override string GetDetailsString()
    {
        return "";
    }

    public override  string GetStringRepresentation()
    {
        return "|"+GetName()+"|"+GetDescription()+"|"+GetPoints()+"|"+ Convert.ToString(_amountCompleted)+"|"+Convert.ToString(_target)+"|"+Convert.ToString(_bonus);
    }


}
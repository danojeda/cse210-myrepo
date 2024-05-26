
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
        //_amountCompleted =0;
    }

    public override void RecordEvent()
    {
      
      Console.WriteLine($"Congratulations, you have earned {GetPoints()} ");
      _amountCompleted++;
      
      
    }

    public override bool IsComplete()
    {   
        if (_amountCompleted == _target)
        {
            return true;
        }else{
            return false;
        }
        
    } 


    public override string GetDetailsString()
    {   
        

        return  base.GetDetailsString() +  "- Currently completed: " + Convert.ToString(_amountCompleted) + "/" + Convert.ToString(_target);
    }

    public override  string GetStringRepresentation()
    {
        return "ChecklistGoal|"+GetName()+"|"+GetDescription()+"|"+GetPoints()+"|"+ Convert.ToString(_amountCompleted)+"|"+Convert.ToString(_target)+"|"+Convert.ToString(_bonus);
    }

    public void SetAmmountCompleted(int amount)
    {
        _amountCompleted = amount;
    }

   
   

    public override string GetPoints()
    {
        if (_amountCompleted == _target)
        {
            return Convert.ToString(int.Parse(base.GetPoints()) + _bonus);
        }else{
            return base.GetPoints();
        }
        
    }
}
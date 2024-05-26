using System;

class Program
{
    static void Main(string[] args)
    {
        

        List<Goal> myGoalList = new List<Goal>();
        
        GoalManager myGoalManager = new GoalManager(myGoalList,0);
        
        myGoalManager.Start();
        
        
    }
}




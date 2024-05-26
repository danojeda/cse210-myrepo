using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");

        List<Goal> myGoalList = new List<Goal>();
        GoalManager myGoalManager = new GoalManager(myGoalList,0);
        myGoalManager.Start();
        //  public GoalManager(List<Goal> goals, int score)
        // Create a goal manager oibject
        //Call the start function on that object
        
    }
}




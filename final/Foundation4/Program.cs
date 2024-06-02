using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");

        // Let's create some datetimes:
        DateTime myDate1 = new DateTime(2024,06,20);
        DateTime myDate2 = new DateTime(2024,06,22);
        DateTime myDate3 = new DateTime(2024,06,24);

        //write a program that creates at least one activity of each type. 

       
        RunningActivity myRunningActivity = new RunningActivity (4.8,myDate1,60);
       
        CyclingActivity myCyclingActivity = new CyclingActivity (2,myDate2,30);
       
        SwimmingActivity mySwimmingActivity = new SwimmingActivity (45,myDate3,10);


        //Put each of these activities in the same list. 
       
        List <Activity> myActivities = new List<Activity>();
        myActivities.Add(myRunningActivity);
        myActivities.Add(myCyclingActivity);
        myActivities.Add(mySwimmingActivity);

        
        //Then iterate through this list and call the GetSummary method on each item and display the results.
        foreach (Activity activity in myActivities)
        {
            string thisActivity = activity.GetSummary();
            Console.WriteLine(thisActivity);
        }



    }
}
using System.Diagnostics.Contracts;

public class Activity
{
    //For each activity, they want to track the the date and the length of the activity in minutes. 
    
    private DateTime _date;
    private int _minutes;


    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    //In addition, the base class should contain virtual methods for getting the distance, speed, pace.

    public virtual decimal GetDistance()
    {
        return 1.2M;
    }

    public virtual decimal GetSpeed()
    {
        return 1.2M;
    }

    public virtual decimal GetPace()
    {
        return 1.2M;
    }

    public virtual string  GetSummary()
    {
        return "";
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public string GetDate()
    {
        return _date.ToString("dd MMMM yyyy");
    }



    


}
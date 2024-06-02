
public class RunningActivity : Activity
{
    //Running: distance
    private double _distance;
    public RunningActivity(double distance,DateTime date, int minutes) : base(date, minutes)
    {
        _distance = distance;        

    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        double thisSpeed = _distance * 60 /GetMinutes();
        return thisSpeed;


    }


    public override double GetPace()
    {
        //Pace = 60 / speed
        double thisPace = 60 /GetSpeed();
        return thisPace;
    }


    public override string  GetSummary()
    {
        //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return GetDate() + " Running (" + GetMinutes() + " min): Distance " + GetDistance() + " km, Speed: "+GetSpeed() +" kph, Pace: " + GetPace() + " min per km";
        //return "";
    }




}
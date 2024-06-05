
public class RunningActivity : Activity
{
    //Running: distance
    private decimal _distance;
    public RunningActivity(decimal distance,DateTime date, int minutes) : base(date, minutes)
    {
        _distance = distance;        

    }

    public override decimal GetDistance()
    {
        return _distance;
    }

    public override decimal GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        decimal thisSpeed = _distance * 60m /GetMinutes();
        return thisSpeed;


    }


    public override decimal GetPace()
    {
        //Pace = 60 / speed
        decimal thisPace = 60m /GetSpeed();
        return thisPace;
    }


    public override string  GetSummary()
    {
        //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return GetDate() + " Running (" + GetMinutes() + " min): Distance " + GetDistance().ToString("F2") + " km, Speed: "+GetSpeed().ToString("F2") +" kph, Pace: " + GetPace().ToString("F2") + " min per km";
        //return "";
    }




}
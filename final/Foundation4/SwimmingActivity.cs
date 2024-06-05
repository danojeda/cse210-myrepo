
public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    public SwimmingActivity(int laps,DateTime date, int minutes) : base(date, minutes)
    {
        _numberOfLaps = laps;
    }


    public override decimal GetDistance()
    {
         
        decimal thisDistance =  _numberOfLaps * 50m / 1000m;
        return thisDistance;
        
    }


    public override decimal GetSpeed()
    {
        
        decimal thisDistance = GetDistance();
        decimal thisSpeed = (thisDistance / GetMinutes())*60m;
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
        return GetDate() + " Swimming (" + GetMinutes() + " min): Distance " + GetDistance().ToString("F2") +" km, Speed: "+GetSpeed().ToString("F2") + " kph, Pace: " + GetPace().ToString("F2") + " min per km"  ;
    }
}




//Swimming: number of laps
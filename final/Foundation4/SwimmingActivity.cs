
public class SwimmingActivity : Activity
{
    private int _numberOfLaps;
    public SwimmingActivity(int laps,DateTime date, int minutes) : base(date, minutes)
    {
        _numberOfLaps = laps;
    }


    public override double GetDistance()
    {
          // Distance (km) = swimming laps * 50 / 1000
        double thisDistance =  _numberOfLaps * 50 / 1000;
        return thisDistance;
    }


    public override double GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        double thisDistance = GetDistance();
        double thisSpeed = (thisDistance / GetMinutes())*60;
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
        return GetDate() + " Swimming (" + GetMinutes() + " min): Distance " + GetDistance() +" km, Speed: "+GetSpeed() + " kph, Pace: " + GetPace() + " min per km"  ;
    }
}




//Swimming: number of laps
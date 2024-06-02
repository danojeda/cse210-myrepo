
public class CyclingActivity: Activity
{
    private double _speed;

    public CyclingActivity(double speed,DateTime date, int minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
      //Speed (mph or kph) = (distance / minutes) * 60
       double thisDistance =  _speed * GetMinutes()/60;
       return thisDistance;

    }

    public override double GetSpeed()
    {
        return _speed;
    }


    public override double GetPace()
    {
        //  //Pace = 60 / speed
        double thisPace = 60 / GetSpeed();
        return thisPace;
    }

    public override string  GetSummary()
    {
       //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return GetDate() + " Cycling (" + GetMinutes() + " min): Distance " + GetDistance() + " km, Speed: "+GetSpeed() +" kph, Pace: " + GetPace() + " min per km"  ;
    }
}



//Cycling: speed
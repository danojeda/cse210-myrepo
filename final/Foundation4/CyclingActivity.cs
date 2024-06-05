
public class CyclingActivity: Activity
{
    private decimal _speed;

    public CyclingActivity(decimal speed,DateTime date, int minutes) : base(date, minutes)
    {
        _speed = speed;
    }

    public override decimal GetDistance()
    {
      //Speed (mph or kph) = (distance / minutes) * 60
       decimal thisDistance =  _speed * GetMinutes()/60m;
       return thisDistance;

    }

    public override decimal GetSpeed()
    {
        return _speed;
    }


    public override decimal GetPace()
    {
        //  //Pace = 60 / speed
        decimal thisPace = 60m / GetSpeed();
        return thisPace;
    }

    public override string  GetSummary()
    {
       //03 Nov 2022 Running (30 min): Distance 4.8 km, Speed: 9.7 kph, Pace: 6.25 min per km
        return GetDate() + " Cycling (" + GetMinutes() + " min): Distance " + GetDistance().ToString("F2") + " km, Speed: "+GetSpeed().ToString("F2") +" kph, Pace: " + GetPace().ToString("F2") + " min per km"  ;
    }
}



//Cycling: speed

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string weather,string eventTitle, string description, DateTime date, TimeSpan time, Address address) : base(eventTitle, description, date, time, address)
    {
        _weather = weather;
    }

    //Full details - Lists all of the above, plus type of event and information specific to that event type. For outdoor gatherings, this includes a statement of the weather.

    public override string GetFullDetails()
    {
        string thisOutdoorGathering = GetStandardDetails();
        return thisOutdoorGathering + "\n" + "This is an Outdoor Gathering." + "\n" + "Please condider that the weather will be " + _weather + ".";
        
    }

    // Short description - Lists the type of event, title, and the date.
    public override string ShortDescription()
    {
        return "This is an Outdoor Gathering, " + GetTitle() + ", " + GetDate() ;
        
    }

}




//Outdoor gatherings, which do not have a limit on attendees, but need to track the weather forecast.
using System.ComponentModel;

public class Event
{
    //Regardless of the type, all events need to have an Event Title, Description, Date, Time, and Address.

    private string _eventTitle;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;


    public Event (string eventTitle, string description , DateTime date, TimeSpan time, Address address )
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address; 
    }

    public string GetStandardDetails()
    {
        return "Event: "+_eventTitle +": "+ _description + ". Date: " + _date.ToString("dd/MM/yyy")  + ". Time: " + GetTime() + ", Address: " +_address.GetAddress();
        
    }

    public virtual string GetFullDetails()
    {
        return "";
    }

    public virtual string ShortDescription()
    {
        return "";       
    }

    public string GetDate()
    {
        return _date.ToString("dd/MM/yyyy");
       
    }

    public string GetTime()
    {
        return Convert.ToString(_time);
    }

    public string GetTitle()
    {
        return _eventTitle;
    }
    

}
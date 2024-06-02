
public class Reception : Event
{
    //Receptions, which require people to RSVP, or register, beforehand.
    private string _email;
    
    public Reception(string email,string eventTitle, string description, DateTime date, TimeSpan time, Address address) : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }

    //Full details - Lists all of the above, plus type of event and information specific to that event type. For receptions this includes an email for RSVP.

    public override string GetFullDetails()
    {
        
        string thisReception = GetStandardDetails();
        return thisReception + "\n" + "This event is a Reception."+  "\n" + "Please confirm your attendance to this e-mail address: " + _email;
        
       
    }

    // // Short description - Lists the type of event, title, and the date.

    public override string ShortDescription()
    {
        
        return "This is a Reception, " + GetTitle() + ", " + GetDate();
        
    }

}







//// public Event (string eventTitle, string description , DateTime date, TimeSpan time, string address )


public class Lecture : Event
{
    //Lectures, which have a speaker and have a limited capacity.
    private string _speaker;
    private int _capacity;


    
    public Lecture(string speaker, int capacity,string eventTitle, string description, DateTime date, TimeSpan time, Address address) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Full details - Lists all of the above, plus type of event and information specific to that event type. For lectures, this includes the speaker name and capacity

    public override string GetFullDetails()
    {
        string thisEvent = GetStandardDetails();
        return  thisEvent + '\n' + "This event is a Lecture."+ "\n" +"The speaker for this event will be " + _speaker + ".\n" +  "This event has a max capacity of " + Convert.ToString(_capacity) + " attendants.";
    }


    // Short description - Lists the type of event, title, and the date.

    public override string ShortDescription()
    {
        return "This is a Lecture." + " " + GetTitle() + ", " + GetDate();
        
       
    }



}
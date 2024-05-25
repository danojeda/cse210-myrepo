public class Goal
{
    private String _shortName;
    private String _description;
    private String _points;

    public Goal(string name, string description , string points)
    {
        _shortName = name;
        _description = description;
        _points = points;

    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public virtual String GetDetailsString()
    {
        return "";
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }
}
public abstract  class Goal
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

    public virtual string GetDetailsString()
    {   
        
        if (IsComplete())
        {
            return ".[X] " +_shortName +"(" +_description+ ")."; 
        }else{
            return ".[ ] " +_shortName +"(" +_description+ ")."; 
        }
        
    }

    public virtual string GetStringRepresentation()
    {
        return "";
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual string GetPoints()
    {
        return _points;
    }
}
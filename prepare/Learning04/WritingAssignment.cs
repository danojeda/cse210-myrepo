public class WritingAssignment : Assignment
{
    private String _title;

    //  public MathAssignment (String bookSection, String problems, String name, String topic): base (name,topic)
    public WritingAssignment (String title, String name, String topic): base (name,topic)
    {
        _title = title;

    }

    public String GetWritingInformation()
    {
        return _title;
    }
    
   
}
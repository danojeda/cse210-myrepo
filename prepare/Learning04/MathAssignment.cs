public class MathAssignment : Assignment
{
    private String _textBookSection;
    private String _problems;

    public MathAssignment (String bookSection, String problems, String name, String topic): base (name,topic)
    {
        // , String name, String topic
        _textBookSection = bookSection;
        _problems = problems;
        //  Assignment (String name, String topic)
        //Assignment (name, topic);

    }

    public String GetHomeworkList()
    {
        return "Section " +_textBookSection + " Problems " + _problems;
        /*
        Roberto Rodriguez - Fractions
        Section 7.3 Problems 8-19
        */
    }

}
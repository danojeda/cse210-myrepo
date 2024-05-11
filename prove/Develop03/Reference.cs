public class Reference
{
    private String _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;


    public  Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public  Reference (String book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public String GetDisplayText()
    {   
        //Console.WriteLine($"{_book} {_chapter}:{_verse}.");
        if (_endVerse == 0)
        {
            String  thisReference = _book + " " + _chapter.ToString() + ":" + _verse.ToString() ;
            return thisReference;
        }else
        {
            String thisReference = _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
            return thisReference;
        }    


        
    }



}
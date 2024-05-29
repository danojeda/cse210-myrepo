public class Comment
{
    private string _personName;
    private string _content;


    public Comment (string personName, string content)
    {
        _personName = personName;
        _content = content;
    }

    public void DisplayCommentDetail()
    {
        Console.WriteLine($"{_personName}: {_content}");
        Console.WriteLine();
    }

    /*public void SetComment(string personName, string content)
    {
        _personName = personName;
        _content = content;
    }
    */
}
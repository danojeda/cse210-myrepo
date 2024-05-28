public class Video
{
    private String _title;
    private string _author;
    private int _length;
    protected List<Comment> _videoComments = new List<Comment>();


    public  Video(string titel, string author, int length, List<Comment> videoComments)
    {
        _title = titel;
        _author = author;
        _length = length;
        _videoComments = videoComments;

    }
    public int GetNumberOfComments()
    {
        return _videoComments.Count;
    }

    public string GetVideoDetails()
    {
        return "Title: "+ _title+ ", by "+ _author + ", " + Convert.ToString(_length)+" mins. "+ "Total comments: "+Convert.ToString(GetNumberOfComments())     ;
    }

    public void ShowComments()
    {
        Console.WriteLine("Comments:");
        Console.WriteLine(" ");
        foreach(Comment comment in _videoComments)
        {   
            
            comment.DisplayCommentDetail();

        }
    } 
}
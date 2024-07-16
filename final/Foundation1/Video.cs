public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public Video(string title, string author, int minutes, int seconds)
    {
        _title = title;
        _author = author;
        _length = minutes*60 + seconds;
        _comments = new List<Comment>();
    }


    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayMetaData()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Full length: {_length} seconds");
    }

    public void DisplayComments()
    {
        Console.WriteLine($"{_comments.Count} comments");
        foreach(Comment c in _comments)
        {
            Console.WriteLine($"{c.GetAuthor()}: {c.GetText()}");
        }
    }
}
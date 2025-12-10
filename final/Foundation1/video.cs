using System.Transactions;

public class Video
{
    public string _vTitle;
    public  string _vAuther;
    public int _vTime;
    public List<Comment> _videoComments;



    public Video(string vTitle, string vAuther, int vTime)
    {
        _vTitle = vTitle;
        _vAuther = vAuther;
        _vTime = vTime;
        _videoComments = new List<Comment>();        
    }
    public void AddComment(Comment comment)
    {
        _videoComments.Add(comment);
    }
    public void DisplayVideoInfo()
    {

        Console.WriteLine($"\nVideo legth: {_vTime} seconds");
        Console.WriteLine($"Title: {_vTitle}");
        Console.WriteLine($"Author: {_vAuther}");
    }
    public int GetCommentCount()
    {
        return _videoComments.Count;
    }
    
}
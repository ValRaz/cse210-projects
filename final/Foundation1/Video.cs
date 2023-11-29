using System;

class Video {
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    //Constructor for video details and comment list
    public Video(string title, string author, int lengthInSeconds) {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();
    }

    //Getter for video details
    public string GetTitle() {
        return _title;
    }

    //Getter for Author
    public string GetAuthor() {
        return _author;
    }

    //Getter for video length in seconds
    public int GetLengthInSeconds() {
        return _lengthInSeconds;
    }

    //Adds a comment to the video's comment list
    public void AddComment(string commenterName, string commentText) {
        Comment comment  = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }

    //Getter for the list of comments
    public List<Comment> GetComments() {
        return _comments;
    }

    //Getter for the count of comments
    public int GetcountOfComments() {
        return _comments.Count;
    }
}
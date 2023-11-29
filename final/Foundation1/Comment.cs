using System;
using System.Collections.Generic;

class Comment {
    private string _commenterName;
    private string _commentText;

    //Constructor for comment details
    public Comment(string commenterName, string commentText) {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    //Getter for commentor name
    public string GetCommenterName() {
        return _commenterName;
    }

    //Getter for comment text
    public string GetCommentText() {
        return _commentText;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogSingleton.Models
{
    public class Comment
    {
        public string Message { get; set; }
        public static int NextCommentID = 0;
        public int CommentID { get; set; }
        public int BlogPostID { get; set; }
        public DateTime Date {get; set;}
        public Comment(string message, int blogpostid)
        {
            Message = message;
            CommentID = NextCommentID++;
            BlogPostID = blogpostid;
            Date = DateTime.Today;
        }
        public Comment()
        {

        }
    }
}